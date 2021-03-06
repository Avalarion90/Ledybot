﻿namespace Ledybot
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tb_PokemonToFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lv_log = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pkmnSent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Export = new System.Windows.Forms.Button();
            this.cb_Blacklist = new System.Windows.Forms.CheckBox();
            this.tc_Control = new System.Windows.Forms.TabControl();
            this.tp_GTS = new System.Windows.Forms.TabPage();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.tb_thread = new System.Windows.Forms.TextBox();
            this.cb_Reddit = new System.Windows.Forms.CheckBox();
            this.btn_Banlist = new System.Windows.Forms.Button();
            this.btn_ShowPaths = new System.Windows.Forms.Button();
            this.tp_Injection = new System.Windows.Forms.TabPage();
            this.btn_WCDelete = new System.Windows.Forms.Button();
            this.btn_WCInject = new System.Windows.Forms.Button();
            this.nud_SlotWCInjection = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_BrowseWCInject = new System.Windows.Forms.Button();
            this.tb_WCInjection = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.nud_CountInjection = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Inject = new System.Windows.Forms.Button();
            this.nud_SlotInjection = new System.Windows.Forms.NumericUpDown();
            this.nud_BoxInjection = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BrowseInject = new System.Windows.Forms.Button();
            this.tb_FileInjection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_Breeding = new System.Windows.Forms.TabPage();
            this.btn_EggStop = new System.Windows.Forms.Button();
            this.btn_EggStart = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_EggAvailable = new System.Windows.Forms.Button();
            this.tb_Settings = new System.Windows.Forms.TabPage();
            this.nud_DefaultCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Subreddit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ofd_Injection = new System.Windows.Forms.OpenFileDialog();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.disconnectTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ofd_WCInjection = new System.Windows.Forms.OpenFileDialog();
            this.tc_Control.SuspendLayout();
            this.tp_GTS.SuspendLayout();
            this.tp_Injection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlotWCInjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CountInjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlotInjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BoxInjection)).BeginInit();
            this.tp_Breeding.SuspendLayout();
            this.tb_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DefaultCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(13, 13);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(100, 20);
            this.tb_IP.TabIndex = 0;
            this.tb_IP.Text = "192.168.1.19";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(119, 13);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 20);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // tb_PokemonToFind
            // 
            this.tb_PokemonToFind.Location = new System.Drawing.Point(6, 19);
            this.tb_PokemonToFind.Name = "tb_PokemonToFind";
            this.tb_PokemonToFind.Size = new System.Drawing.Size(100, 20);
            this.tb_PokemonToFind.TabIndex = 6;
            this.tb_PokemonToFind.Text = "Ledyba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Deposited Pokemon:";
            // 
            // btn_Start
            // 
            this.btn_Start.Enabled = false;
            this.btn_Start.Location = new System.Drawing.Point(147, 45);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(58, 23);
            this.btn_Start.TabIndex = 16;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(211, 45);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(58, 23);
            this.btn_Stop.TabIndex = 17;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lv_log
            // 
            this.lv_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Trainer,
            this.NickName,
            this.Country,
            this.subRegion,
            this.pkmnSent,
            this.FC});
            this.lv_log.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_log.Location = new System.Drawing.Point(6, 74);
            this.lv_log.Name = "lv_log";
            this.lv_log.Size = new System.Drawing.Size(353, 386);
            this.lv_log.TabIndex = 18;
            this.lv_log.UseCompatibleStateImageBehavior = false;
            this.lv_log.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 55;
            // 
            // Trainer
            // 
            this.Trainer.Text = "Trainer";
            this.Trainer.Width = 73;
            // 
            // NickName
            // 
            this.NickName.Text = "Name";
            this.NickName.Width = 49;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            // 
            // subRegion
            // 
            this.subRegion.Text = "Sub Region";
            // 
            // pkmnSent
            // 
            this.pkmnSent.Text = "Pokemon Sent";
            this.pkmnSent.Width = 62;
            // 
            // FC
            // 
            this.FC.Text = "FC";
            this.FC.Width = 110;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(6, 466);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(354, 23);
            this.btn_Export.TabIndex = 19;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // cb_Blacklist
            // 
            this.cb_Blacklist.AutoSize = true;
            this.cb_Blacklist.Location = new System.Drawing.Point(275, 49);
            this.cb_Blacklist.Name = "cb_Blacklist";
            this.cb_Blacklist.Size = new System.Drawing.Size(72, 17);
            this.cb_Blacklist.TabIndex = 20;
            this.cb_Blacklist.Text = "Black List";
            this.cb_Blacklist.UseVisualStyleBackColor = true;
            // 
            // tc_Control
            // 
            this.tc_Control.Controls.Add(this.tp_GTS);
            this.tc_Control.Controls.Add(this.tp_Injection);
            this.tc_Control.Controls.Add(this.tp_Breeding);
            this.tc_Control.Controls.Add(this.tb_Settings);
            this.tc_Control.Location = new System.Drawing.Point(1, 33);
            this.tc_Control.Name = "tc_Control";
            this.tc_Control.SelectedIndex = 0;
            this.tc_Control.Size = new System.Drawing.Size(377, 587);
            this.tc_Control.TabIndex = 28;
            // 
            // tp_GTS
            // 
            this.tp_GTS.AllowDrop = true;
            this.tp_GTS.Controls.Add(this.btn_Clear);
            this.tp_GTS.Controls.Add(this.btn_Import);
            this.tp_GTS.Controls.Add(this.tb_thread);
            this.tp_GTS.Controls.Add(this.cb_Reddit);
            this.tp_GTS.Controls.Add(this.btn_Banlist);
            this.tp_GTS.Controls.Add(this.btn_ShowPaths);
            this.tp_GTS.Controls.Add(this.label1);
            this.tp_GTS.Controls.Add(this.tb_PokemonToFind);
            this.tp_GTS.Controls.Add(this.btn_Start);
            this.tp_GTS.Controls.Add(this.cb_Blacklist);
            this.tp_GTS.Controls.Add(this.btn_Stop);
            this.tp_GTS.Controls.Add(this.btn_Export);
            this.tp_GTS.Controls.Add(this.lv_log);
            this.tp_GTS.Location = new System.Drawing.Point(4, 22);
            this.tp_GTS.Name = "tp_GTS";
            this.tp_GTS.Padding = new System.Windows.Forms.Padding(3);
            this.tp_GTS.Size = new System.Drawing.Size(369, 561);
            this.tp_GTS.TabIndex = 0;
            this.tp_GTS.Text = "GTS";
            this.tp_GTS.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(6, 524);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(354, 23);
            this.btn_Clear.TabIndex = 33;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(6, 495);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(354, 23);
            this.btn_Import.TabIndex = 32;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // tb_thread
            // 
            this.tb_thread.Location = new System.Drawing.Point(193, 19);
            this.tb_thread.Name = "tb_thread";
            this.tb_thread.Size = new System.Drawing.Size(76, 20);
            this.tb_thread.TabIndex = 31;
            // 
            // cb_Reddit
            // 
            this.cb_Reddit.AutoSize = true;
            this.cb_Reddit.Location = new System.Drawing.Point(275, 23);
            this.cb_Reddit.Name = "cb_Reddit";
            this.cb_Reddit.Size = new System.Drawing.Size(57, 17);
            this.cb_Reddit.TabIndex = 30;
            this.cb_Reddit.Text = "Reddit";
            this.cb_Reddit.UseVisualStyleBackColor = true;
            // 
            // btn_Banlist
            // 
            this.btn_Banlist.Location = new System.Drawing.Point(112, 17);
            this.btn_Banlist.Name = "btn_Banlist";
            this.btn_Banlist.Size = new System.Drawing.Size(75, 23);
            this.btn_Banlist.TabIndex = 29;
            this.btn_Banlist.Text = "Ban List";
            this.btn_Banlist.UseVisualStyleBackColor = true;
            this.btn_Banlist.Click += new System.EventHandler(this.btn_Banlist_Click);
            // 
            // btn_ShowPaths
            // 
            this.btn_ShowPaths.Location = new System.Drawing.Point(5, 45);
            this.btn_ShowPaths.Name = "btn_ShowPaths";
            this.btn_ShowPaths.Size = new System.Drawing.Size(136, 23);
            this.btn_ShowPaths.TabIndex = 28;
            this.btn_ShowPaths.Text = "Giveaway Details";
            this.btn_ShowPaths.UseVisualStyleBackColor = true;
            this.btn_ShowPaths.Click += new System.EventHandler(this.btn_ShowPaths_Click);
            // 
            // tp_Injection
            // 
            this.tp_Injection.AllowDrop = true;
            this.tp_Injection.Controls.Add(this.btn_WCDelete);
            this.tp_Injection.Controls.Add(this.btn_WCInject);
            this.tp_Injection.Controls.Add(this.nud_SlotWCInjection);
            this.tp_Injection.Controls.Add(this.label7);
            this.tp_Injection.Controls.Add(this.btn_BrowseWCInject);
            this.tp_Injection.Controls.Add(this.tb_WCInjection);
            this.tp_Injection.Controls.Add(this.label12);
            this.tp_Injection.Controls.Add(this.btn_Delete);
            this.tp_Injection.Controls.Add(this.nud_CountInjection);
            this.tp_Injection.Controls.Add(this.label10);
            this.tp_Injection.Controls.Add(this.btn_Inject);
            this.tp_Injection.Controls.Add(this.nud_SlotInjection);
            this.tp_Injection.Controls.Add(this.nud_BoxInjection);
            this.tp_Injection.Controls.Add(this.label9);
            this.tp_Injection.Controls.Add(this.label3);
            this.tp_Injection.Controls.Add(this.btn_BrowseInject);
            this.tp_Injection.Controls.Add(this.tb_FileInjection);
            this.tp_Injection.Controls.Add(this.label2);
            this.tp_Injection.Location = new System.Drawing.Point(4, 22);
            this.tp_Injection.Name = "tp_Injection";
            this.tp_Injection.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Injection.Size = new System.Drawing.Size(369, 561);
            this.tp_Injection.TabIndex = 1;
            this.tp_Injection.Text = "Injection";
            this.tp_Injection.UseVisualStyleBackColor = true;
            this.tp_Injection.DragDrop += new System.Windows.Forms.DragEventHandler(this.tp_Injection_DragDrop);
            this.tp_Injection.DragEnter += new System.Windows.Forms.DragEventHandler(this.tp_Injection_DragEnter);
            // 
            // btn_WCDelete
            // 
            this.btn_WCDelete.Enabled = false;
            this.btn_WCDelete.Location = new System.Drawing.Point(6, 258);
            this.btn_WCDelete.Name = "btn_WCDelete";
            this.btn_WCDelete.Size = new System.Drawing.Size(354, 23);
            this.btn_WCDelete.TabIndex = 21;
            this.btn_WCDelete.Text = "Delete";
            this.btn_WCDelete.UseVisualStyleBackColor = true;
            this.btn_WCDelete.Click += new System.EventHandler(this.btn_WCDelete_Click);
            // 
            // btn_WCInject
            // 
            this.btn_WCInject.Enabled = false;
            this.btn_WCInject.Location = new System.Drawing.Point(6, 229);
            this.btn_WCInject.Name = "btn_WCInject";
            this.btn_WCInject.Size = new System.Drawing.Size(354, 23);
            this.btn_WCInject.TabIndex = 18;
            this.btn_WCInject.Text = "Inject";
            this.btn_WCInject.UseVisualStyleBackColor = true;
            this.btn_WCInject.Click += new System.EventHandler(this.btn_WCInject_Click);
            // 
            // nud_SlotWCInjection
            // 
            this.nud_SlotWCInjection.Location = new System.Drawing.Point(8, 202);
            this.nud_SlotWCInjection.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nud_SlotWCInjection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SlotWCInjection.Name = "nud_SlotWCInjection";
            this.nud_SlotWCInjection.Size = new System.Drawing.Size(38, 20);
            this.nud_SlotWCInjection.TabIndex = 17;
            this.nud_SlotWCInjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_SlotWCInjection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Slot:";
            // 
            // btn_BrowseWCInject
            // 
            this.btn_BrowseWCInject.Location = new System.Drawing.Point(290, 162);
            this.btn_BrowseWCInject.Name = "btn_BrowseWCInject";
            this.btn_BrowseWCInject.Size = new System.Drawing.Size(75, 20);
            this.btn_BrowseWCInject.TabIndex = 13;
            this.btn_BrowseWCInject.Text = "Browse";
            this.btn_BrowseWCInject.UseVisualStyleBackColor = true;
            this.btn_BrowseWCInject.Click += new System.EventHandler(this.btn_BrowseWCInject_Click);
            // 
            // tb_WCInjection
            // 
            this.tb_WCInjection.Location = new System.Drawing.Point(6, 162);
            this.tb_WCInjection.Name = "tb_WCInjection";
            this.tb_WCInjection.ReadOnly = true;
            this.tb_WCInjection.Size = new System.Drawing.Size(279, 20);
            this.tb_WCInjection.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "WC:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(7, 120);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(354, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // nud_CountInjection
            // 
            this.nud_CountInjection.Location = new System.Drawing.Point(95, 64);
            this.nud_CountInjection.Maximum = new decimal(new int[] {
            960,
            0,
            0,
            0});
            this.nud_CountInjection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CountInjection.Name = "nud_CountInjection";
            this.nud_CountInjection.Size = new System.Drawing.Size(38, 20);
            this.nud_CountInjection.TabIndex = 9;
            this.nud_CountInjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_CountInjection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Count:";
            // 
            // btn_Inject
            // 
            this.btn_Inject.Enabled = false;
            this.btn_Inject.Location = new System.Drawing.Point(7, 91);
            this.btn_Inject.Name = "btn_Inject";
            this.btn_Inject.Size = new System.Drawing.Size(354, 23);
            this.btn_Inject.TabIndex = 7;
            this.btn_Inject.Text = "Inject";
            this.btn_Inject.UseVisualStyleBackColor = true;
            this.btn_Inject.Click += new System.EventHandler(this.btn_Inject_Click);
            // 
            // nud_SlotInjection
            // 
            this.nud_SlotInjection.Location = new System.Drawing.Point(51, 64);
            this.nud_SlotInjection.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nud_SlotInjection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SlotInjection.Name = "nud_SlotInjection";
            this.nud_SlotInjection.Size = new System.Drawing.Size(38, 20);
            this.nud_SlotInjection.TabIndex = 6;
            this.nud_SlotInjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_SlotInjection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SlotInjection.ValueChanged += new System.EventHandler(this.nud_SlotInjection_ValueChanged);
            // 
            // nud_BoxInjection
            // 
            this.nud_BoxInjection.Location = new System.Drawing.Point(7, 64);
            this.nud_BoxInjection.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nud_BoxInjection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_BoxInjection.Name = "nud_BoxInjection";
            this.nud_BoxInjection.Size = new System.Drawing.Size(38, 20);
            this.nud_BoxInjection.TabIndex = 5;
            this.nud_BoxInjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_BoxInjection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_BoxInjection.ValueChanged += new System.EventHandler(this.nud_BoxInjection_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Slot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Box:";
            // 
            // btn_BrowseInject
            // 
            this.btn_BrowseInject.Location = new System.Drawing.Point(291, 24);
            this.btn_BrowseInject.Name = "btn_BrowseInject";
            this.btn_BrowseInject.Size = new System.Drawing.Size(75, 20);
            this.btn_BrowseInject.TabIndex = 2;
            this.btn_BrowseInject.Text = "Browse";
            this.btn_BrowseInject.UseVisualStyleBackColor = true;
            this.btn_BrowseInject.Click += new System.EventHandler(this.btn_BrowseInject_Click);
            // 
            // tb_FileInjection
            // 
            this.tb_FileInjection.Location = new System.Drawing.Point(7, 24);
            this.tb_FileInjection.Name = "tb_FileInjection";
            this.tb_FileInjection.ReadOnly = true;
            this.tb_FileInjection.Size = new System.Drawing.Size(279, 20);
            this.tb_FileInjection.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File:";
            // 
            // tp_Breeding
            // 
            this.tp_Breeding.Controls.Add(this.btn_EggStop);
            this.tp_Breeding.Controls.Add(this.btn_EggStart);
            this.tp_Breeding.Controls.Add(this.label11);
            this.tp_Breeding.Controls.Add(this.btn_EggAvailable);
            this.tp_Breeding.Location = new System.Drawing.Point(4, 22);
            this.tp_Breeding.Name = "tp_Breeding";
            this.tp_Breeding.Size = new System.Drawing.Size(369, 561);
            this.tp_Breeding.TabIndex = 2;
            this.tp_Breeding.Text = "Breeding";
            this.tp_Breeding.UseVisualStyleBackColor = true;
            // 
            // btn_EggStop
            // 
            this.btn_EggStop.Enabled = false;
            this.btn_EggStop.Location = new System.Drawing.Point(203, 30);
            this.btn_EggStop.Name = "btn_EggStop";
            this.btn_EggStop.Size = new System.Drawing.Size(75, 23);
            this.btn_EggStop.TabIndex = 3;
            this.btn_EggStop.Text = "Stop";
            this.btn_EggStop.UseVisualStyleBackColor = true;
            this.btn_EggStop.Click += new System.EventHandler(this.btn_EggStop_Click);
            // 
            // btn_EggStart
            // 
            this.btn_EggStart.Enabled = false;
            this.btn_EggStart.Location = new System.Drawing.Point(122, 30);
            this.btn_EggStart.Name = "btn_EggStart";
            this.btn_EggStart.Size = new System.Drawing.Size(75, 23);
            this.btn_EggStart.TabIndex = 2;
            this.btn_EggStart.Text = "Start";
            this.btn_EggStart.UseVisualStyleBackColor = true;
            this.btn_EggStart.Click += new System.EventHandler(this.btn_EggStart_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Egg Always Available:";
            // 
            // btn_EggAvailable
            // 
            this.btn_EggAvailable.Enabled = false;
            this.btn_EggAvailable.Location = new System.Drawing.Point(8, 4);
            this.btn_EggAvailable.Name = "btn_EggAvailable";
            this.btn_EggAvailable.Size = new System.Drawing.Size(353, 23);
            this.btn_EggAvailable.TabIndex = 0;
            this.btn_EggAvailable.Text = "Egg Available";
            this.btn_EggAvailable.UseVisualStyleBackColor = true;
            this.btn_EggAvailable.Click += new System.EventHandler(this.btn_EggAvailable_Click);
            // 
            // tb_Settings
            // 
            this.tb_Settings.Controls.Add(this.nud_DefaultCount);
            this.tb_Settings.Controls.Add(this.label5);
            this.tb_Settings.Controls.Add(this.tb_Subreddit);
            this.tb_Settings.Controls.Add(this.label4);
            this.tb_Settings.Location = new System.Drawing.Point(4, 22);
            this.tb_Settings.Name = "tb_Settings";
            this.tb_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Settings.Size = new System.Drawing.Size(369, 561);
            this.tb_Settings.TabIndex = 3;
            this.tb_Settings.Text = "Settings";
            this.tb_Settings.UseVisualStyleBackColor = true;
            // 
            // nud_DefaultCount
            // 
            this.nud_DefaultCount.Location = new System.Drawing.Point(241, 32);
            this.nud_DefaultCount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_DefaultCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nud_DefaultCount.Name = "nud_DefaultCount";
            this.nud_DefaultCount.Size = new System.Drawing.Size(120, 20);
            this.nud_DefaultCount.TabIndex = 3;
            this.nud_DefaultCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_DefaultCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Default Count:";
            // 
            // tb_Subreddit
            // 
            this.tb_Subreddit.Location = new System.Drawing.Point(68, 6);
            this.tb_Subreddit.Name = "tb_Subreddit";
            this.tb_Subreddit.Size = new System.Drawing.Size(293, 20);
            this.tb_Subreddit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subreddit:";
            // 
            // ofd_Injection
            // 
            this.ofd_Injection.FileName = "Pokemon.pk7";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(200, 13);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 20);
            this.btn_Disconnect.TabIndex = 29;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // disconnectTimer
            // 
            this.disconnectTimer.Tick += new System.EventHandler(this.disconnectTimer_Tick);
            // 
            // ofd_WCInjection
            // 
            this.ofd_WCInjection.FileName = "WC.wc7";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 620);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.tc_Control);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.tb_IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ledybot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tc_Control.ResumeLayout(false);
            this.tp_GTS.ResumeLayout(false);
            this.tp_GTS.PerformLayout();
            this.tp_Injection.ResumeLayout(false);
            this.tp_Injection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlotWCInjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CountInjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlotInjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BoxInjection)).EndInit();
            this.tp_Breeding.ResumeLayout(false);
            this.tp_Breeding.PerformLayout();
            this.tb_Settings.ResumeLayout(false);
            this.tb_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DefaultCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox tb_PokemonToFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ListView lv_log;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Trainer;
        private System.Windows.Forms.ColumnHeader NickName;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.CheckBox cb_Blacklist;
        private System.Windows.Forms.TabControl tc_Control;
        private System.Windows.Forms.TabPage tp_GTS;
        private System.Windows.Forms.TabPage tp_Injection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Inject;
        private System.Windows.Forms.NumericUpDown nud_SlotInjection;
        private System.Windows.Forms.NumericUpDown nud_BoxInjection;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BrowseInject;
        private System.Windows.Forms.TextBox tb_FileInjection;
        private System.Windows.Forms.OpenFileDialog ofd_Injection;
        private System.Windows.Forms.NumericUpDown nud_CountInjection;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TabPage tp_Breeding;
        private System.Windows.Forms.Button btn_EggAvailable;
        private System.Windows.Forms.Button btn_EggStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_EggStop;
        private System.Windows.Forms.Timer disconnectTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ColumnHeader FC;
        private System.Windows.Forms.Button btn_ShowPaths;
        private System.Windows.Forms.Button btn_Banlist;
        private System.Windows.Forms.CheckBox cb_Reddit;
        private System.Windows.Forms.TextBox tb_thread;
        private System.Windows.Forms.ColumnHeader pkmnSent;
        private System.Windows.Forms.TabPage tb_Settings;
        private System.Windows.Forms.TextBox tb_Subreddit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_DefaultCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader subRegion;
        private System.Windows.Forms.Button btn_WCDelete;
        private System.Windows.Forms.Button btn_WCInject;
        private System.Windows.Forms.NumericUpDown nud_SlotWCInjection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_BrowseWCInject;
        private System.Windows.Forms.TextBox tb_WCInjection;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog ofd_WCInjection;
    }
}

