using System;
using System.Collections.Generic;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;




namespace FtDRoller
{
    public class GoogleSheetLoader
    {
        private readonly UserCredential UserCredential;
        private readonly String SheetUrl;
        private readonly SheetsService Service;

        public GoogleSheetLoader(String sheetUrl, UserCredential userCredential)
        {
            UserCredential = userCredential;
            SheetUrl = sheetUrl;
            Service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = UserCredential
            });

        }

        public IList<IList<Object>> GetSheetRows()
        {
            String spreadsheetId = GetSpreadsheetId();

            // get the name of the first sheet
            SpreadsheetsResource.GetRequest sheetRequest = Service.Spreadsheets.Get(spreadsheetId);
            Spreadsheet spreadsheet = sheetRequest.Execute();
            Sheet sheet = spreadsheet.Sheets[0];
            String sheetId = sheet.Properties.Title;

            // get the data using the sheet name
            String range = sheetId;
            SpreadsheetsResource.ValuesResource.GetRequest request = Service.Spreadsheets.Values.Get(spreadsheetId, range);
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            return values;
        }

        // Extract the spreadsheet id from the url.
        private String GetSpreadsheetId()
        {
            Regex UrlV1 = new Regex(@"key=(?<sheetId>[^&#]+)");
            Regex UrlV2 = new Regex(@"/spreadsheets/d/(?<sheetId>[a-zA-Z0-9-_]+)");
            Regex[] urlRegexes = { UrlV1, UrlV2 };

            foreach (var urlRegex in urlRegexes) {
                MatchCollection matches = urlRegex.Matches(SheetUrl);
                if (matches.Count > 1) {
                    throw new System.ArgumentException("Invalid spreadsheet url", "");
                } else if (matches.Count == 1) {
                    Match match = matches[0];
                    GroupCollection groups = match.Groups;
                    return groups["sheetId"].Value;
                }
            }
            throw new System.ArgumentException("Invalid spreadsheet url", "");
        }

        static String tokenFilename = "token.json";
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };

        public static UserCredential LoadCredential(String credentialFilename = "credentials.json") {
            UserCredential credential;

            using (var stream = new FileStream(credentialFilename, FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(tokenFilename, true)
                ).Result;
            }
            return credential;

        }
    }
}
