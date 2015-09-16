namespace ConfigurationEditor
{
    partial class ConfigurationForm
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.checkBoxAmount = new System.Windows.Forms.CheckBox();
            this.checkBoxMemo = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckNum = new System.Windows.Forms.CheckBox();
            this.groupBoxColumns = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxPayee = new System.Windows.Forms.CheckBox();
            this.numericUpDownPayee = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.numericUpDownDate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMemo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCheckNum = new System.Windows.Forms.NumericUpDown();
            this.textBoxCommaSeparators = new System.Windows.Forms.TextBox();
            this.labelCommaSeparators = new System.Windows.Forms.Label();
            this.numericUpDownSkipLines = new System.Windows.Forms.NumericUpDown();
            this.labelSkipLines = new System.Windows.Forms.Label();
            this.textBoxNumberDecimalSeparator = new System.Windows.Forms.TextBox();
            this.labelNumberDecimalSeparator = new System.Windows.Forms.Label();
            this.tableLayoutPanelOther = new System.Windows.Forms.TableLayoutPanel();
            this.labelNumberGroupSeparator = new System.Windows.Forms.Label();
            this.textBoxNumberGroupSeparator = new System.Windows.Forms.TextBox();
            this.groupBoxDateFormat = new System.Windows.Forms.GroupBox();
            this.textBoxDateFormat = new System.Windows.Forms.TextBox();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxColumns.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkipLines)).BeginInit();
            this.tableLayoutPanelOther.SuspendLayout();
            this.groupBoxDateFormat.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(3, 3);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(118, 39);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // checkBoxAmount
            // 
            this.checkBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAmount.AutoSize = true;
            this.checkBoxAmount.Checked = true;
            this.checkBoxAmount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAmount.Location = new System.Drawing.Point(3, 55);
            this.checkBoxAmount.Name = "checkBoxAmount";
            this.checkBoxAmount.Size = new System.Drawing.Size(171, 20);
            this.checkBoxAmount.TabIndex = 4;
            this.checkBoxAmount.Text = "Amount";
            this.checkBoxAmount.UseVisualStyleBackColor = true;
            this.checkBoxAmount.CheckedChanged += new System.EventHandler(this.checkBoxAmount_CheckedChanged);
            // 
            // checkBoxMemo
            // 
            this.checkBoxMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMemo.AutoSize = true;
            this.checkBoxMemo.Checked = true;
            this.checkBoxMemo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMemo.Location = new System.Drawing.Point(3, 81);
            this.checkBoxMemo.Name = "checkBoxMemo";
            this.checkBoxMemo.Size = new System.Drawing.Size(171, 20);
            this.checkBoxMemo.TabIndex = 5;
            this.checkBoxMemo.Text = "Memo";
            this.checkBoxMemo.UseVisualStyleBackColor = true;
            this.checkBoxMemo.CheckedChanged += new System.EventHandler(this.checkBoxMemo_CheckedChanged);
            // 
            // checkBoxCheckNum
            // 
            this.checkBoxCheckNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCheckNum.AutoSize = true;
            this.checkBoxCheckNum.Checked = true;
            this.checkBoxCheckNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckNum.Location = new System.Drawing.Point(3, 107);
            this.checkBoxCheckNum.Name = "checkBoxCheckNum";
            this.checkBoxCheckNum.Size = new System.Drawing.Size(171, 23);
            this.checkBoxCheckNum.TabIndex = 6;
            this.checkBoxCheckNum.Text = "Check #";
            this.checkBoxCheckNum.UseVisualStyleBackColor = true;
            this.checkBoxCheckNum.CheckedChanged += new System.EventHandler(this.checkBoxCheckNum_CheckedChanged);
            // 
            // groupBoxColumns
            // 
            this.groupBoxColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColumns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxColumns.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxColumns.Location = new System.Drawing.Point(12, 12);
            this.groupBoxColumns.Name = "groupBoxColumns";
            this.groupBoxColumns.Size = new System.Drawing.Size(248, 158);
            this.groupBoxColumns.TabIndex = 8;
            this.groupBoxColumns.TabStop = false;
            this.groupBoxColumns.Text = "Columns";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxPayee, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownPayee, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxAmount, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownAmount, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxMemo, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownMemo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxCheckNum, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownCheckNum, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(236, 133);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // checkBoxPayee
            // 
            this.checkBoxPayee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPayee.AutoSize = true;
            this.checkBoxPayee.Checked = true;
            this.checkBoxPayee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPayee.Location = new System.Drawing.Point(3, 3);
            this.checkBoxPayee.Name = "checkBoxPayee";
            this.checkBoxPayee.Size = new System.Drawing.Size(171, 20);
            this.checkBoxPayee.TabIndex = 2;
            this.checkBoxPayee.Text = "Payee";
            this.checkBoxPayee.UseVisualStyleBackColor = true;
            this.checkBoxPayee.CheckedChanged += new System.EventHandler(this.checkBoxPayee_CheckedChanged);
            // 
            // numericUpDownPayee
            // 
            this.numericUpDownPayee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPayee.Location = new System.Drawing.Point(180, 3);
            this.numericUpDownPayee.Name = "numericUpDownPayee";
            this.numericUpDownPayee.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownPayee.TabIndex = 9;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Checked = true;
            this.checkBoxDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDate.Location = new System.Drawing.Point(3, 29);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(171, 20);
            this.checkBoxDate.TabIndex = 3;
            this.checkBoxDate.Text = "Date";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // numericUpDownDate
            // 
            this.numericUpDownDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDate.Location = new System.Drawing.Point(180, 29);
            this.numericUpDownDate.Name = "numericUpDownDate";
            this.numericUpDownDate.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownDate.TabIndex = 10;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(180, 55);
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownAmount.TabIndex = 11;
            // 
            // numericUpDownMemo
            // 
            this.numericUpDownMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMemo.Location = new System.Drawing.Point(180, 81);
            this.numericUpDownMemo.Name = "numericUpDownMemo";
            this.numericUpDownMemo.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownMemo.TabIndex = 12;
            // 
            // numericUpDownCheckNum
            // 
            this.numericUpDownCheckNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCheckNum.Location = new System.Drawing.Point(180, 107);
            this.numericUpDownCheckNum.Name = "numericUpDownCheckNum";
            this.numericUpDownCheckNum.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownCheckNum.TabIndex = 13;
            // 
            // textBoxCommaSeparators
            // 
            this.textBoxCommaSeparators.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommaSeparators.Location = new System.Drawing.Point(180, 3);
            this.textBoxCommaSeparators.Name = "textBoxCommaSeparators";
            this.textBoxCommaSeparators.Size = new System.Drawing.Size(53, 20);
            this.textBoxCommaSeparators.TabIndex = 9;
            // 
            // labelCommaSeparators
            // 
            this.labelCommaSeparators.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCommaSeparators.AutoSize = true;
            this.labelCommaSeparators.Location = new System.Drawing.Point(3, 0);
            this.labelCommaSeparators.Name = "labelCommaSeparators";
            this.labelCommaSeparators.Size = new System.Drawing.Size(171, 26);
            this.labelCommaSeparators.TabIndex = 10;
            this.labelCommaSeparators.Text = "Comma Separators";
            this.labelCommaSeparators.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownSkipLines
            // 
            this.numericUpDownSkipLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSkipLines.Location = new System.Drawing.Point(180, 29);
            this.numericUpDownSkipLines.Name = "numericUpDownSkipLines";
            this.numericUpDownSkipLines.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownSkipLines.TabIndex = 11;
            // 
            // labelSkipLines
            // 
            this.labelSkipLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSkipLines.AutoSize = true;
            this.labelSkipLines.Location = new System.Drawing.Point(3, 26);
            this.labelSkipLines.Name = "labelSkipLines";
            this.labelSkipLines.Size = new System.Drawing.Size(171, 26);
            this.labelSkipLines.TabIndex = 12;
            this.labelSkipLines.Text = "Skip Lines";
            this.labelSkipLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNumberDecimalSeparator
            // 
            this.textBoxNumberDecimalSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumberDecimalSeparator.Location = new System.Drawing.Point(180, 55);
            this.textBoxNumberDecimalSeparator.Name = "textBoxNumberDecimalSeparator";
            this.textBoxNumberDecimalSeparator.Size = new System.Drawing.Size(53, 20);
            this.textBoxNumberDecimalSeparator.TabIndex = 16;
            // 
            // labelNumberDecimalSeparator
            // 
            this.labelNumberDecimalSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberDecimalSeparator.AutoSize = true;
            this.labelNumberDecimalSeparator.Location = new System.Drawing.Point(3, 52);
            this.labelNumberDecimalSeparator.Name = "labelNumberDecimalSeparator";
            this.labelNumberDecimalSeparator.Size = new System.Drawing.Size(171, 26);
            this.labelNumberDecimalSeparator.TabIndex = 15;
            this.labelNumberDecimalSeparator.Text = "Number Decimal Separator";
            this.labelNumberDecimalSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelOther
            // 
            this.tableLayoutPanelOther.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelOther.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelOther.ColumnCount = 2;
            this.tableLayoutPanelOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOther.Controls.Add(this.labelCommaSeparators, 0, 0);
            this.tableLayoutPanelOther.Controls.Add(this.textBoxCommaSeparators, 1, 0);
            this.tableLayoutPanelOther.Controls.Add(this.labelSkipLines, 0, 1);
            this.tableLayoutPanelOther.Controls.Add(this.numericUpDownSkipLines, 1, 1);
            this.tableLayoutPanelOther.Controls.Add(this.labelNumberDecimalSeparator, 0, 2);
            this.tableLayoutPanelOther.Controls.Add(this.textBoxNumberDecimalSeparator, 1, 2);
            this.tableLayoutPanelOther.Controls.Add(this.labelNumberGroupSeparator, 0, 3);
            this.tableLayoutPanelOther.Controls.Add(this.textBoxNumberGroupSeparator, 1, 3);
            this.tableLayoutPanelOther.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanelOther.Name = "tableLayoutPanelOther";
            this.tableLayoutPanelOther.RowCount = 4;
            this.tableLayoutPanelOther.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOther.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOther.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOther.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOther.Size = new System.Drawing.Size(236, 104);
            this.tableLayoutPanelOther.TabIndex = 22;
            // 
            // labelNumberGroupSeparator
            // 
            this.labelNumberGroupSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberGroupSeparator.AutoSize = true;
            this.labelNumberGroupSeparator.Location = new System.Drawing.Point(3, 78);
            this.labelNumberGroupSeparator.Name = "labelNumberGroupSeparator";
            this.labelNumberGroupSeparator.Size = new System.Drawing.Size(171, 26);
            this.labelNumberGroupSeparator.TabIndex = 17;
            this.labelNumberGroupSeparator.Text = "Number Group Separator";
            this.labelNumberGroupSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNumberGroupSeparator
            // 
            this.textBoxNumberGroupSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumberGroupSeparator.Location = new System.Drawing.Point(180, 81);
            this.textBoxNumberGroupSeparator.Name = "textBoxNumberGroupSeparator";
            this.textBoxNumberGroupSeparator.Size = new System.Drawing.Size(53, 20);
            this.textBoxNumberGroupSeparator.TabIndex = 18;
            // 
            // groupBoxDateFormat
            // 
            this.groupBoxDateFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDateFormat.Controls.Add(this.textBoxDateFormat);
            this.groupBoxDateFormat.Location = new System.Drawing.Point(12, 176);
            this.groupBoxDateFormat.Name = "groupBoxDateFormat";
            this.groupBoxDateFormat.Size = new System.Drawing.Size(248, 51);
            this.groupBoxDateFormat.TabIndex = 23;
            this.groupBoxDateFormat.TabStop = false;
            this.groupBoxDateFormat.Text = "Date Format";
            // 
            // textBoxDateFormat
            // 
            this.textBoxDateFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDateFormat.Location = new System.Drawing.Point(9, 19);
            this.textBoxDateFormat.Name = "textBoxDateFormat";
            this.textBoxDateFormat.Size = new System.Drawing.Size(230, 20);
            this.textBoxDateFormat.TabIndex = 0;
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOther.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxOther.Controls.Add(this.tableLayoutPanelOther);
            this.groupBoxOther.Location = new System.Drawing.Point(12, 233);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(248, 129);
            this.groupBoxOther.TabIndex = 24;
            this.groupBoxOther.TabStop = false;
            this.groupBoxOther.Text = "Other";
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonApply, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonReset, 1, 0);
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(12, 368);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(248, 45);
            this.tableLayoutPanelButtons.TabIndex = 25;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.Location = new System.Drawing.Point(127, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(118, 39);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ConfigurationForm
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(272, 425);
            this.Controls.Add(this.groupBoxColumns);
            this.Controls.Add(this.groupBoxDateFormat);
            this.Controls.Add(this.groupBoxOther);
            this.Controls.Add(this.tableLayoutPanelButtons);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(464, 464);
            this.MinimumSize = new System.Drawing.Size(288, 464);
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.groupBoxColumns.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkipLines)).EndInit();
            this.tableLayoutPanelOther.ResumeLayout(false);
            this.tableLayoutPanelOther.PerformLayout();
            this.groupBoxDateFormat.ResumeLayout(false);
            this.groupBoxDateFormat.PerformLayout();
            this.groupBoxOther.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.CheckBox checkBoxAmount;
        private System.Windows.Forms.CheckBox checkBoxMemo;
        private System.Windows.Forms.CheckBox checkBoxCheckNum;
        private System.Windows.Forms.GroupBox groupBoxColumns;
        private System.Windows.Forms.CheckBox checkBoxPayee;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownDate;
        private System.Windows.Forms.NumericUpDown numericUpDownPayee;
        private System.Windows.Forms.NumericUpDown numericUpDownCheckNum;
        private System.Windows.Forms.NumericUpDown numericUpDownMemo;
        private System.Windows.Forms.TextBox textBoxCommaSeparators;
        private System.Windows.Forms.Label labelCommaSeparators;
        private System.Windows.Forms.NumericUpDown numericUpDownSkipLines;
        private System.Windows.Forms.Label labelSkipLines;
        private System.Windows.Forms.TextBox textBoxNumberDecimalSeparator;
        private System.Windows.Forms.Label labelNumberDecimalSeparator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOther;
        private System.Windows.Forms.TextBox textBoxNumberGroupSeparator;
        private System.Windows.Forms.Label labelNumberGroupSeparator;
        private System.Windows.Forms.GroupBox groupBoxDateFormat;
        private System.Windows.Forms.TextBox textBoxDateFormat;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonReset;
    }
}

