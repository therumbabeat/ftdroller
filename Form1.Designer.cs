namespace FtDRoller
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCharSheetURL = new System.Windows.Forms.TextBox();
            this.lblCharSheetURL = new System.Windows.Forms.Label();
            this.cmbSkillSelect = new System.Windows.Forms.ComboBox();
            this.lblCharSheetSkill = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.chkBuffActive = new System.Windows.Forms.CheckBox();
            this.lblBuffActive = new System.Windows.Forms.Label();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.lblIsBuff = new System.Windows.Forms.Label();
            this.chkIsBuff = new System.Windows.Forms.CheckBox();
            this.numPosAspects = new System.Windows.Forms.NumericUpDown();
            this.lblNumPosAspect = new System.Windows.Forms.Label();
            this.txtSkillValue = new System.Windows.Forms.TextBox();
            this.txtPosAspectValue = new System.Windows.Forms.TextBox();
            this.txtMaxChakra = new System.Windows.Forms.TextBox();
            this.txtCurrentChakra = new System.Windows.Forms.TextBox();
            this.lblCurrentChakra = new System.Windows.Forms.Label();
            this.lblMaxChakra = new System.Windows.Forms.Label();
            this.txtMiscBonuses = new System.Windows.Forms.TextBox();
            this.lblMiscBonuses = new System.Windows.Forms.Label();
            this.lblTotalSkill = new System.Windows.Forms.Label();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.txtNegAspectValue = new System.Windows.Forms.TextBox();
            this.lblNegAspects = new System.Windows.Forms.Label();
            this.numNegAspects = new System.Windows.Forms.NumericUpDown();
            this.lblMiscPenalties = new System.Windows.Forms.Label();
            this.txtMiscPenalties = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPosAspects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNegAspects)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCharSheetURL
            // 
            this.txtCharSheetURL.Location = new System.Drawing.Point(129, 12);
            this.txtCharSheetURL.Name = "txtCharSheetURL";
            this.txtCharSheetURL.Size = new System.Drawing.Size(153, 20);
            this.txtCharSheetURL.TabIndex = 0;
            // 
            // lblCharSheetURL
            // 
            this.lblCharSheetURL.AutoSize = true;
            this.lblCharSheetURL.Location = new System.Drawing.Point(7, 15);
            this.lblCharSheetURL.Name = "lblCharSheetURL";
            this.lblCharSheetURL.Size = new System.Drawing.Size(116, 13);
            this.lblCharSheetURL.TabIndex = 1;
            this.lblCharSheetURL.Text = "Enter Char Sheet URL:";
            // 
            // cmbSkillSelect
            // 
            this.cmbSkillSelect.FormattingEnabled = true;
            this.cmbSkillSelect.Location = new System.Drawing.Point(129, 67);
            this.cmbSkillSelect.Name = "cmbSkillSelect";
            this.cmbSkillSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbSkillSelect.TabIndex = 2;
            // 
            // lblCharSheetSkill
            // 
            this.lblCharSheetSkill.AutoSize = true;
            this.lblCharSheetSkill.Location = new System.Drawing.Point(21, 70);
            this.lblCharSheetSkill.Name = "lblCharSheetSkill";
            this.lblCharSheetSkill.Size = new System.Drawing.Size(102, 13);
            this.lblCharSheetSkill.TabIndex = 3;
            this.lblCharSheetSkill.Text = "Select or Enter Skill:";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(288, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(45, 20);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // chkBuffActive
            // 
            this.chkBuffActive.AutoSize = true;
            this.chkBuffActive.Location = new System.Drawing.Point(83, 163);
            this.chkBuffActive.Name = "chkBuffActive";
            this.chkBuffActive.Size = new System.Drawing.Size(15, 14);
            this.chkBuffActive.TabIndex = 5;
            this.chkBuffActive.UseVisualStyleBackColor = true;
            // 
            // lblBuffActive
            // 
            this.lblBuffActive.AutoSize = true;
            this.lblBuffActive.Location = new System.Drawing.Point(12, 163);
            this.lblBuffActive.Name = "lblBuffActive";
            this.lblBuffActive.Size = new System.Drawing.Size(65, 13);
            this.lblBuffActive.TabIndex = 6;
            this.lblBuffActive.Text = "Buff Active?";
            // 
            // txtSkillName
            // 
            this.txtSkillName.Location = new System.Drawing.Point(104, 159);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(95, 20);
            this.txtSkillName.TabIndex = 7;
            this.txtSkillName.Text = "Skill Name Here";
            // 
            // lblIsBuff
            // 
            this.lblIsBuff.AutoSize = true;
            this.lblIsBuff.Location = new System.Drawing.Point(534, 164);
            this.lblIsBuff.Name = "lblIsBuff";
            this.lblIsBuff.Size = new System.Drawing.Size(42, 13);
            this.lblIsBuff.TabIndex = 10;
            this.lblIsBuff.Text = "Is buff?";
            // 
            // chkIsBuff
            // 
            this.chkIsBuff.AutoSize = true;
            this.chkIsBuff.Location = new System.Drawing.Point(582, 165);
            this.chkIsBuff.Name = "chkIsBuff";
            this.chkIsBuff.Size = new System.Drawing.Size(15, 14);
            this.chkIsBuff.TabIndex = 8;
            this.chkIsBuff.UseVisualStyleBackColor = true;
            // 
            // numPosAspects
            // 
            this.numPosAspects.Location = new System.Drawing.Point(354, 161);
            this.numPosAspects.Name = "numPosAspects";
            this.numPosAspects.Size = new System.Drawing.Size(41, 20);
            this.numPosAspects.TabIndex = 11;
            // 
            // lblNumPosAspect
            // 
            this.lblNumPosAspect.AutoSize = true;
            this.lblNumPosAspect.Location = new System.Drawing.Point(256, 163);
            this.lblNumPosAspect.Name = "lblNumPosAspect";
            this.lblNumPosAspect.Size = new System.Drawing.Size(98, 13);
            this.lblNumPosAspect.TabIndex = 12;
            this.lblNumPosAspect.Text = "# +Aspects applied";
            // 
            // txtSkillValue
            // 
            this.txtSkillValue.Location = new System.Drawing.Point(206, 159);
            this.txtSkillValue.Name = "txtSkillValue";
            this.txtSkillValue.Size = new System.Drawing.Size(44, 20);
            this.txtSkillValue.TabIndex = 13;
            // 
            // txtPosAspectValue
            // 
            this.txtPosAspectValue.Enabled = false;
            this.txtPosAspectValue.Location = new System.Drawing.Point(401, 161);
            this.txtPosAspectValue.Name = "txtPosAspectValue";
            this.txtPosAspectValue.Size = new System.Drawing.Size(21, 20);
            this.txtPosAspectValue.TabIndex = 14;
            // 
            // txtMaxChakra
            // 
            this.txtMaxChakra.Location = new System.Drawing.Point(276, 111);
            this.txtMaxChakra.Name = "txtMaxChakra";
            this.txtMaxChakra.Size = new System.Drawing.Size(100, 20);
            this.txtMaxChakra.TabIndex = 15;
            // 
            // txtCurrentChakra
            // 
            this.txtCurrentChakra.Location = new System.Drawing.Point(99, 111);
            this.txtCurrentChakra.Name = "txtCurrentChakra";
            this.txtCurrentChakra.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentChakra.TabIndex = 16;
            // 
            // lblCurrentChakra
            // 
            this.lblCurrentChakra.AutoSize = true;
            this.lblCurrentChakra.Location = new System.Drawing.Point(15, 114);
            this.lblCurrentChakra.Name = "lblCurrentChakra";
            this.lblCurrentChakra.Size = new System.Drawing.Size(78, 13);
            this.lblCurrentChakra.TabIndex = 17;
            this.lblCurrentChakra.Text = "Current Chakra";
            // 
            // lblMaxChakra
            // 
            this.lblMaxChakra.AutoSize = true;
            this.lblMaxChakra.Location = new System.Drawing.Point(206, 114);
            this.lblMaxChakra.Name = "lblMaxChakra";
            this.lblMaxChakra.Size = new System.Drawing.Size(64, 13);
            this.lblMaxChakra.TabIndex = 18;
            this.lblMaxChakra.Text = "Max Chakra";
            // 
            // txtMiscBonuses
            // 
            this.txtMiscBonuses.Location = new System.Drawing.Point(507, 160);
            this.txtMiscBonuses.Name = "txtMiscBonuses";
            this.txtMiscBonuses.Size = new System.Drawing.Size(21, 20);
            this.txtMiscBonuses.TabIndex = 19;
            // 
            // lblMiscBonuses
            // 
            this.lblMiscBonuses.AutoSize = true;
            this.lblMiscBonuses.Location = new System.Drawing.Point(428, 164);
            this.lblMiscBonuses.Name = "lblMiscBonuses";
            this.lblMiscBonuses.Size = new System.Drawing.Size(73, 13);
            this.lblMiscBonuses.TabIndex = 20;
            this.lblMiscBonuses.Text = "Misc Bonuses";
            // 
            // lblTotalSkill
            // 
            this.lblTotalSkill.AutoSize = true;
            this.lblTotalSkill.Location = new System.Drawing.Point(534, 191);
            this.lblTotalSkill.Name = "lblTotalSkill";
            this.lblTotalSkill.Size = new System.Drawing.Size(34, 13);
            this.lblTotalSkill.TabIndex = 21;
            this.lblTotalSkill.Text = "Total:";
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.Location = new System.Drawing.Point(574, 187);
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.Size = new System.Drawing.Size(39, 20);
            this.txtTotalValue.TabIndex = 22;
            // 
            // txtNegAspectValue
            // 
            this.txtNegAspectValue.Enabled = false;
            this.txtNegAspectValue.Location = new System.Drawing.Point(401, 188);
            this.txtNegAspectValue.Name = "txtNegAspectValue";
            this.txtNegAspectValue.Size = new System.Drawing.Size(21, 20);
            this.txtNegAspectValue.TabIndex = 25;
            // 
            // lblNegAspects
            // 
            this.lblNegAspects.AutoSize = true;
            this.lblNegAspects.Location = new System.Drawing.Point(256, 190);
            this.lblNegAspects.Name = "lblNegAspects";
            this.lblNegAspects.Size = new System.Drawing.Size(95, 13);
            this.lblNegAspects.TabIndex = 24;
            this.lblNegAspects.Text = "# -Aspects applied";
            // 
            // numNegAspects
            // 
            this.numNegAspects.Location = new System.Drawing.Point(354, 188);
            this.numNegAspects.Name = "numNegAspects";
            this.numNegAspects.Size = new System.Drawing.Size(41, 20);
            this.numNegAspects.TabIndex = 23;
            // 
            // lblMiscPenalties
            // 
            this.lblMiscPenalties.AutoSize = true;
            this.lblMiscPenalties.Location = new System.Drawing.Point(428, 191);
            this.lblMiscPenalties.Name = "lblMiscPenalties";
            this.lblMiscPenalties.Size = new System.Drawing.Size(75, 13);
            this.lblMiscPenalties.TabIndex = 27;
            this.lblMiscPenalties.Text = "Misc Penalties";
            // 
            // txtMiscPenalties
            // 
            this.txtMiscPenalties.Location = new System.Drawing.Point(507, 187);
            this.txtMiscPenalties.Name = "txtMiscPenalties";
            this.txtMiscPenalties.Size = new System.Drawing.Size(21, 20);
            this.txtMiscPenalties.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMiscPenalties);
            this.Controls.Add(this.txtMiscPenalties);
            this.Controls.Add(this.txtNegAspectValue);
            this.Controls.Add(this.lblNegAspects);
            this.Controls.Add(this.numNegAspects);
            this.Controls.Add(this.txtTotalValue);
            this.Controls.Add(this.lblTotalSkill);
            this.Controls.Add(this.lblMiscBonuses);
            this.Controls.Add(this.txtMiscBonuses);
            this.Controls.Add(this.lblMaxChakra);
            this.Controls.Add(this.lblCurrentChakra);
            this.Controls.Add(this.txtCurrentChakra);
            this.Controls.Add(this.txtMaxChakra);
            this.Controls.Add(this.txtPosAspectValue);
            this.Controls.Add(this.txtSkillValue);
            this.Controls.Add(this.lblNumPosAspect);
            this.Controls.Add(this.numPosAspects);
            this.Controls.Add(this.lblIsBuff);
            this.Controls.Add(this.chkIsBuff);
            this.Controls.Add(this.txtSkillName);
            this.Controls.Add(this.lblBuffActive);
            this.Controls.Add(this.chkBuffActive);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblCharSheetSkill);
            this.Controls.Add(this.cmbSkillSelect);
            this.Controls.Add(this.lblCharSheetURL);
            this.Controls.Add(this.txtCharSheetURL);
            this.Name = "formMain";
            this.Text = "FtD Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.numPosAspects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNegAspects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCharSheetURL;
        private System.Windows.Forms.Label lblCharSheetURL;
        private System.Windows.Forms.ComboBox cmbSkillSelect;
        private System.Windows.Forms.Label lblCharSheetSkill;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.CheckBox chkBuffActive;
        private System.Windows.Forms.Label lblBuffActive;
        private System.Windows.Forms.TextBox txtSkillName;
        private System.Windows.Forms.Label lblIsBuff;
        private System.Windows.Forms.CheckBox chkIsBuff;
        private System.Windows.Forms.NumericUpDown numPosAspects;
        private System.Windows.Forms.Label lblNumPosAspect;
        private System.Windows.Forms.TextBox txtSkillValue;
        private System.Windows.Forms.TextBox txtPosAspectValue;
        private System.Windows.Forms.TextBox txtMaxChakra;
        private System.Windows.Forms.TextBox txtCurrentChakra;
        private System.Windows.Forms.Label lblCurrentChakra;
        private System.Windows.Forms.Label lblMaxChakra;
        private System.Windows.Forms.TextBox txtMiscBonuses;
        private System.Windows.Forms.Label lblMiscBonuses;
        private System.Windows.Forms.Label lblTotalSkill;
        private System.Windows.Forms.TextBox txtTotalValue;
        private System.Windows.Forms.TextBox txtNegAspectValue;
        private System.Windows.Forms.Label lblNegAspects;
        private System.Windows.Forms.NumericUpDown numNegAspects;
        private System.Windows.Forms.Label lblMiscPenalties;
        private System.Windows.Forms.TextBox txtMiscPenalties;
        private System.Windows.Forms.Button button1;
    }
}

