﻿namespace EDDiscovery
{
    partial class TravelHistoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelHistoryControl));
            this.richTextBox_History = new System.Windows.Forms.RichTextBox();
            this.button_RefreshHistory = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxHistoryWindow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMap = new System.Windows.Forms.Button();
            this.textBoxSystem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTrilaterate = new System.Windows.Forms.Button();
            this.buttonRoss = new System.Windows.Forms.Button();
            this.buttonEDDB = new System.Windows.Forms.Button();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxEconomy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxGovernment = new System.Windows.Forms.TextBox();
            this.textBoxAllegiance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxVisits = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.textBoxDistText = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrevSystem = new System.Windows.Forms.TextBox();
            this.label_Z = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.labelDistEnter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCmdrName = new System.Windows.Forms.TextBox();
            this.buttonSync = new System.Windows.Forms.Button();
            this.toolTipEddb = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCloseTrilateration = new System.Windows.Forms.Button();
            this.TrilaterationControl = new EDDiscovery.TrilaterationControl();
            this.labelDistanceToNextSystem = new System.Windows.Forms.Label();
            this.textBoxDistanceToNextSystem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_History
            // 
            this.richTextBox_History.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_History.Location = new System.Drawing.Point(21, 3);
            this.richTextBox_History.Name = "richTextBox_History";
            this.richTextBox_History.Size = new System.Drawing.Size(570, 70);
            this.richTextBox_History.TabIndex = 6;
            this.richTextBox_History.Text = "";
            // 
            // button_RefreshHistory
            // 
            this.button_RefreshHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RefreshHistory.Location = new System.Drawing.Point(508, 77);
            this.button_RefreshHistory.Name = "button_RefreshHistory";
            this.button_RefreshHistory.Size = new System.Drawing.Size(83, 23);
            this.button_RefreshHistory.TabIndex = 5;
            this.button_RefreshHistory.Text = "Refresh";
            this.button_RefreshHistory.UseVisualStyleBackColor = true;
            this.button_RefreshHistory.Click += new System.EventHandler(this.button_RefreshHistory_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(17, 76);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(115, 20);
            this.labelHeader.TabIndex = 7;
            this.labelHeader.Text = "Travel history";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTime,
            this.ColumnSystem,
            this.ColumnDistance,
            this.ColumnNote});
            this.dataGridView1.Location = new System.Drawing.Point(21, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 471);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Width = 140;
            // 
            // ColumnSystem
            // 
            this.ColumnSystem.HeaderText = "System";
            this.ColumnSystem.Name = "ColumnSystem";
            this.ColumnSystem.ReadOnly = true;
            this.ColumnSystem.Width = 200;
            // 
            // ColumnDistance
            // 
            this.ColumnDistance.HeaderText = "Distance";
            this.ColumnDistance.Name = "ColumnDistance";
            this.ColumnDistance.ReadOnly = true;
            this.ColumnDistance.Width = 70;
            // 
            // ColumnNote
            // 
            this.ColumnNote.HeaderText = "Note";
            this.ColumnNote.Name = "ColumnNote";
            this.ColumnNote.ReadOnly = true;
            this.ColumnNote.Width = 250;
            // 
            // comboBoxHistoryWindow
            // 
            this.comboBoxHistoryWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHistoryWindow.FormattingEnabled = true;
            this.comboBoxHistoryWindow.Items.AddRange(new object[] {
            "6 Hours",
            "12 Hours",
            "24 Hours",
            "3 days",
            "Week",
            "2 Weeks",
            "Month",
            "All"});
            this.comboBoxHistoryWindow.Location = new System.Drawing.Point(313, 78);
            this.comboBoxHistoryWindow.Name = "comboBoxHistoryWindow";
            this.comboBoxHistoryWindow.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHistoryWindow.TabIndex = 9;
            this.comboBoxHistoryWindow.SelectedIndexChanged += new System.EventHandler(this.comboBoxHistoryWindow_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Show history for last";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.columnDist});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Name";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Location = new System.Drawing.Point(599, 360);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(267, 218);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 200;
            // 
            // columnDist
            // 
            this.columnDist.Text = "Dist";
            this.columnDist.Width = 90;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Closest systems  (from last known position)";
            // 
            // buttonMap
            // 
            this.buttonMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMap.Location = new System.Drawing.Point(787, 76);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(83, 23);
            this.buttonMap.TabIndex = 14;
            this.buttonMap.Text = "3D star map";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSystem
            // 
            this.textBoxSystem.Location = new System.Drawing.Point(50, 6);
            this.textBoxSystem.Name = "textBoxSystem";
            this.textBoxSystem.ReadOnly = true;
            this.textBoxSystem.Size = new System.Drawing.Size(203, 20);
            this.textBoxSystem.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonTrilaterate);
            this.panel1.Controls.Add(this.buttonRoss);
            this.panel1.Controls.Add(this.buttonEDDB);
            this.panel1.Controls.Add(this.textBoxState);
            this.panel1.Controls.Add(this.textBoxEconomy);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBoxGovernment);
            this.panel1.Controls.Add(this.textBoxAllegiance);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxVisits);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.richTextBoxNote);
            this.panel1.Controls.Add(this.textBoxDistText);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.textBoxDistance);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxPrevSystem);
            this.panel1.Controls.Add(this.label_Z);
            this.panel1.Controls.Add(this.textBoxZ);
            this.panel1.Controls.Add(this.labelDistEnter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxY);
            this.panel1.Controls.Add(this.textBoxX);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxSystem);
            this.panel1.Location = new System.Drawing.Point(595, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 235);
            this.panel1.TabIndex = 16;
            // 
            // buttonTrilaterate
            // 
            this.buttonTrilaterate.Location = new System.Drawing.Point(168, 186);
            this.buttonTrilaterate.Name = "buttonTrilaterate";
            this.buttonTrilaterate.Size = new System.Drawing.Size(99, 22);
            this.buttonTrilaterate.TabIndex = 41;
            this.buttonTrilaterate.Text = "Trilaterate";
            this.buttonTrilaterate.UseVisualStyleBackColor = true;
            this.buttonTrilaterate.Click += new System.EventHandler(this.buttonTrilaterate_Click);
            // 
            // buttonRoss
            // 
            this.buttonRoss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRoss.BackgroundImage")));
            this.buttonRoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRoss.FlatAppearance.BorderSize = 0;
            this.buttonRoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoss.Location = new System.Drawing.Point(274, 6);
            this.buttonRoss.Name = "buttonRoss";
            this.buttonRoss.Size = new System.Drawing.Size(16, 20);
            this.buttonRoss.TabIndex = 40;
            this.toolTipEddb.SetToolTip(this.buttonRoss, "Click to edit system in Ross");
            this.buttonRoss.UseVisualStyleBackColor = true;
            this.buttonRoss.Click += new System.EventHandler(this.buttonRoss_Click);
            // 
            // buttonEDDB
            // 
            this.buttonEDDB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEDDB.BackgroundImage")));
            this.buttonEDDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEDDB.FlatAppearance.BorderSize = 0;
            this.buttonEDDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEDDB.Location = new System.Drawing.Point(259, 6);
            this.buttonEDDB.Name = "buttonEDDB";
            this.buttonEDDB.Size = new System.Drawing.Size(16, 20);
            this.buttonEDDB.TabIndex = 39;
            this.toolTipEddb.SetToolTip(this.buttonEDDB, "Click to show system in EDDB");
            this.buttonEDDB.UseVisualStyleBackColor = true;
            this.buttonEDDB.Click += new System.EventHandler(this.buttonEDDB_Click);
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(182, 78);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.Size = new System.Drawing.Size(71, 20);
            this.textBoxState.TabIndex = 37;
            // 
            // textBoxEconomy
            // 
            this.textBoxEconomy.Location = new System.Drawing.Point(182, 61);
            this.textBoxEconomy.Name = "textBoxEconomy";
            this.textBoxEconomy.ReadOnly = true;
            this.textBoxEconomy.Size = new System.Drawing.Size(71, 20);
            this.textBoxEconomy.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "State";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Gov";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxGovernment
            // 
            this.textBoxGovernment.Location = new System.Drawing.Point(50, 78);
            this.textBoxGovernment.Name = "textBoxGovernment";
            this.textBoxGovernment.ReadOnly = true;
            this.textBoxGovernment.Size = new System.Drawing.Size(67, 20);
            this.textBoxGovernment.TabIndex = 35;
            // 
            // textBoxAllegiance
            // 
            this.textBoxAllegiance.Location = new System.Drawing.Point(182, 43);
            this.textBoxAllegiance.Name = "textBoxAllegiance";
            this.textBoxAllegiance.ReadOnly = true;
            this.textBoxAllegiance.Size = new System.Drawing.Size(71, 20);
            this.textBoxAllegiance.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Economy";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Allegiance";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Visits";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxVisits
            // 
            this.textBoxVisits.Location = new System.Drawing.Point(182, 25);
            this.textBoxVisits.Name = "textBoxVisits";
            this.textBoxVisits.ReadOnly = true;
            this.textBoxVisits.Size = new System.Drawing.Size(71, 20);
            this.textBoxVisits.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Note";
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNote.Location = new System.Drawing.Point(29, 114);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(238, 56);
            this.richTextBoxNote.TabIndex = 27;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.Leave += new System.EventHandler(this.richTextBoxNote_Leave);
            // 
            // textBoxDistText
            // 
            this.textBoxDistText.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDistText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDistText.ForeColor = System.Drawing.Color.Red;
            this.textBoxDistText.Location = new System.Drawing.Point(2, 211);
            this.textBoxDistText.Multiline = true;
            this.textBoxDistText.Name = "textBoxDistText";
            this.textBoxDistText.ReadOnly = true;
            this.textBoxDistText.Size = new System.Drawing.Size(263, 28);
            this.textBoxDistText.TabIndex = 26;
            this.textBoxDistText.Text = "Important!!  Use galaxy map to get distance with 2 decimals. Ex 17.44     ";
            this.textBoxDistText.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(6, 186);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(69, 22);
            this.buttonUpdate.TabIndex = 24;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDistance.Location = new System.Drawing.Point(81, 188);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(70, 20);
            this.textBoxDistance.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Distance from";
            // 
            // textBoxPrevSystem
            // 
            this.textBoxPrevSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrevSystem.Location = new System.Drawing.Point(81, 173);
            this.textBoxPrevSystem.Name = "textBoxPrevSystem";
            this.textBoxPrevSystem.ReadOnly = true;
            this.textBoxPrevSystem.Size = new System.Drawing.Size(186, 13);
            this.textBoxPrevSystem.TabIndex = 21;
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(30, 64);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(14, 13);
            this.label_Z.TabIndex = 20;
            this.label_Z.Text = "Z";
            this.label_Z.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(50, 61);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.Size = new System.Drawing.Size(67, 20);
            this.textBoxZ.TabIndex = 19;
            // 
            // labelDistEnter
            // 
            this.labelDistEnter.AutoSize = true;
            this.labelDistEnter.ForeColor = System.Drawing.Color.Black;
            this.labelDistEnter.Location = new System.Drawing.Point(30, 46);
            this.labelDistEnter.Name = "labelDistEnter";
            this.labelDistEnter.Size = new System.Drawing.Size(14, 13);
            this.labelDistEnter.TabIndex = 18;
            this.labelDistEnter.Text = "Y";
            this.labelDistEnter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(50, 43);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(67, 20);
            this.textBoxY.TabIndex = 17;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(50, 25);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(67, 20);
            this.textBoxX.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "System";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(597, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Commander";
            // 
            // textBoxCmdrName
            // 
            this.textBoxCmdrName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmdrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCmdrName.Location = new System.Drawing.Point(702, 2);
            this.textBoxCmdrName.Name = "textBoxCmdrName";
            this.textBoxCmdrName.Size = new System.Drawing.Size(167, 26);
            this.textBoxCmdrName.TabIndex = 18;
            this.textBoxCmdrName.Leave += new System.EventHandler(this.textBoxCmdrName_Leave);
            // 
            // buttonSync
            // 
            this.buttonSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSync.Location = new System.Drawing.Point(702, 34);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(164, 23);
            this.buttonSync.TabIndex = 19;
            this.buttonSync.Text = "Send Distances to EDSC";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // buttonCloseTrilateration
            // 
            this.buttonCloseTrilateration.Location = new System.Drawing.Point(513, 116);
            this.buttonCloseTrilateration.Name = "buttonCloseTrilateration";
            this.buttonCloseTrilateration.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseTrilateration.TabIndex = 21;
            this.buttonCloseTrilateration.Text = "Close";
            this.buttonCloseTrilateration.UseVisualStyleBackColor = true;
            this.buttonCloseTrilateration.Visible = false;
            this.buttonCloseTrilateration.Click += new System.EventHandler(this.buttonCloseTrilateration_Click);
            // 
            // TrilaterationControl
            // 
            this.TrilaterationControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrilaterationControl.Location = new System.Drawing.Point(21, 105);
            this.TrilaterationControl.Name = "TrilaterationControl";
            this.TrilaterationControl.Size = new System.Drawing.Size(570, 472);
            this.TrilaterationControl.TabIndex = 20;
            this.TrilaterationControl.Visible = false;
            this.TrilaterationControl.VisibleChanged += new System.EventHandler(this.TrilaterationControl_VisibleChanged);
            // 
            // labelDistanceToNextSystem
            // 
            this.labelDistanceToNextSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDistanceToNextSystem.AutoSize = true;
            this.labelDistanceToNextSystem.Location = new System.Drawing.Point(592, 60);
            this.labelDistanceToNextSystem.Name = "labelDistanceToNextSystem";
            this.labelDistanceToNextSystem.Size = new System.Drawing.Size(122, 13);
            this.labelDistanceToNextSystem.TabIndex = 20;
            this.labelDistanceToNextSystem.Text = "Distance to next system:";
            // 
            // textBoxDistanceToNextSystem
            // 
            this.textBoxDistanceToNextSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDistanceToNextSystem.Location = new System.Drawing.Point(666, 76);
            this.textBoxDistanceToNextSystem.Name = "textBoxDistanceToNextSystem";
            this.textBoxDistanceToNextSystem.Size = new System.Drawing.Size(48, 20);
            this.textBoxDistanceToNextSystem.TabIndex = 21;
            this.textBoxDistanceToNextSystem.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDistanceToNextSystem_Validating);
            // 
            // TravelHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCloseTrilateration);
            this.Controls.Add(this.textBoxDistanceToNextSystem);
            this.Controls.Add(this.labelDistanceToNextSystem);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.textBoxCmdrName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonMap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxHistoryWindow);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.richTextBox_History);
            this.Controls.Add(this.button_RefreshHistory);
            this.Controls.Add(this.TrilaterationControl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TravelHistoryControl";
            this.Size = new System.Drawing.Size(891, 586);
            this.Load += new System.EventHandler(this.TravelHistoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_RefreshHistory;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxHistoryWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader columnDist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMap;
        internal System.Windows.Forms.RichTextBox richTextBox_History;
        private System.Windows.Forms.TextBox textBoxSystem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrevSystem;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label labelDistEnter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxDistText;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox textBoxCmdrName;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNote;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxVisits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEconomy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAllegiance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxGovernment;
        private System.Windows.Forms.Button buttonEDDB;
        private System.Windows.Forms.ToolTip toolTipEddb;
        private System.Windows.Forms.Button buttonRoss;
        private System.Windows.Forms.Button buttonTrilaterate;
        private TrilaterationControl TrilaterationControl;
        private System.Windows.Forms.Button buttonCloseTrilateration;
        private System.Windows.Forms.Label labelDistanceToNextSystem;
        private System.Windows.Forms.TextBox textBoxDistanceToNextSystem;
    }
}
