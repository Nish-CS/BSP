namespace BSP
{
    partial class frmBudgetMaintenance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMid = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckAllocation = new System.Windows.Forms.CheckBox();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.lblCommodityDescription = new System.Windows.Forms.Label();
            this.lblCommodity = new System.Windows.Forms.Label();
            this.lblFacilityDescription = new System.Windows.Forms.Label();
            this.lblFacility = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblMaterials = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.lblLabour = new System.Windows.Forms.Label();
            this.lblDistribs = new System.Windows.Forms.Label();
            this.lblEscalation = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlBudgetHeader = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbFacility = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Facilty = new System.Windows.Forms.Label();
            this.cmbCommodityDesc = new System.Windows.Forms.ComboBox();
            this.cmbAllocation = new System.Windows.Forms.ComboBox();
            this.cmbTotal = new System.Windows.Forms.ComboBox();
            this.cmbCommodity = new System.Windows.Forms.ComboBox();
            this.cmbFacilityDesc = new System.Windows.Forms.ComboBox();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            this.pnlBudgetHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMid);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlBudgetHeader);
            this.panel1.Controls.Add(this.pnlFormTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 450);
            this.panel1.TabIndex = 0;
            // 
            // panelMid
            // 
            this.panelMid.AutoScroll = true;
            this.panelMid.Controls.Add(this.pnlContent);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 149);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1180, 252);
            this.panelMid.TabIndex = 3;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.dataRepeater1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1180, 252);
            this.pnlContent.TabIndex = 1;
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRepeater1.ItemHeaderVisible = false;
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dataRepeater1.ItemTemplate.Controls.Add(this.button3);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.button2);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.button1);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.ckAllocation);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.txtPackage);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblCommodityDescription);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblCommodity);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblFacilityDescription);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblFacility);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblHours);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblCurrency);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblEquipment);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblVendor);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblMaterials);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblFreight);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblLabour);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblDistribs);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblEscalation);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblQty);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lblTotal);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(1172, 66);
            this.dataRepeater1.Location = new System.Drawing.Point(0, 0);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(1180, 252);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "dataRepeater1";
            this.dataRepeater1.DrawItem += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.DataRepeater1_DrawItem);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1080, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(999, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ckAllocation
            // 
            this.ckAllocation.AutoSize = true;
            this.ckAllocation.Location = new System.Drawing.Point(871, 22);
            this.ckAllocation.Name = "ckAllocation";
            this.ckAllocation.Size = new System.Drawing.Size(15, 14);
            this.ckAllocation.TabIndex = 16;
            this.ckAllocation.UseVisualStyleBackColor = true;
            this.ckAllocation.Validated += new System.EventHandler(this.CkAllocation_Validated);
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(748, 19);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(100, 20);
            this.txtPackage.TabIndex = 15;
            this.txtPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCommodityDescription
            // 
            this.lblCommodityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommodityDescription.Location = new System.Drawing.Point(439, 10);
            this.lblCommodityDescription.Name = "lblCommodityDescription";
            this.lblCommodityDescription.Size = new System.Drawing.Size(282, 13);
            this.lblCommodityDescription.TabIndex = 14;
            this.lblCommodityDescription.Text = "label14";
            // 
            // lblCommodity
            // 
            this.lblCommodity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommodity.Location = new System.Drawing.Point(392, 10);
            this.lblCommodity.Name = "lblCommodity";
            this.lblCommodity.Size = new System.Drawing.Size(41, 13);
            this.lblCommodity.TabIndex = 13;
            this.lblCommodity.Text = "label13";
            // 
            // lblFacilityDescription
            // 
            this.lblFacilityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacilityDescription.Location = new System.Drawing.Point(77, 10);
            this.lblFacilityDescription.Name = "lblFacilityDescription";
            this.lblFacilityDescription.Size = new System.Drawing.Size(309, 13);
            this.lblFacilityDescription.TabIndex = 12;
            this.lblFacilityDescription.Text = "label12";
            // 
            // lblFacility
            // 
            this.lblFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacility.Location = new System.Drawing.Point(20, 10);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(51, 13);
            this.lblFacility.TabIndex = 11;
            this.lblFacility.Text = "label11";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(77, 37);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(41, 13);
            this.lblHours.TabIndex = 10;
            this.lblHours.Text = "label21";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(141, 37);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(41, 13);
            this.lblCurrency.TabIndex = 9;
            this.lblCurrency.Text = "label20";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(211, 37);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(41, 13);
            this.lblEquipment.TabIndex = 8;
            this.lblEquipment.Text = "label19";
            this.lblEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(278, 37);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(41, 13);
            this.lblVendor.TabIndex = 7;
            this.lblVendor.Text = "label18";
            this.lblVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaterials
            // 
            this.lblMaterials.AutoSize = true;
            this.lblMaterials.Location = new System.Drawing.Point(345, 37);
            this.lblMaterials.Name = "lblMaterials";
            this.lblMaterials.Size = new System.Drawing.Size(41, 13);
            this.lblMaterials.TabIndex = 6;
            this.lblMaterials.Text = "label17";
            this.lblMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(412, 37);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(41, 13);
            this.lblFreight.TabIndex = 5;
            this.lblFreight.Text = "label16";
            this.lblFreight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLabour
            // 
            this.lblLabour.AutoSize = true;
            this.lblLabour.Location = new System.Drawing.Point(479, 37);
            this.lblLabour.Name = "lblLabour";
            this.lblLabour.Size = new System.Drawing.Size(41, 13);
            this.lblLabour.TabIndex = 4;
            this.lblLabour.Text = "label15";
            this.lblLabour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDistribs
            // 
            this.lblDistribs.AutoSize = true;
            this.lblDistribs.Location = new System.Drawing.Point(546, 37);
            this.lblDistribs.Name = "lblDistribs";
            this.lblDistribs.Size = new System.Drawing.Size(41, 13);
            this.lblDistribs.TabIndex = 3;
            this.lblDistribs.Text = "label14";
            this.lblDistribs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEscalation
            // 
            this.lblEscalation.AutoSize = true;
            this.lblEscalation.Location = new System.Drawing.Point(613, 37);
            this.lblEscalation.Name = "lblEscalation";
            this.lblEscalation.Size = new System.Drawing.Size(41, 13);
            this.lblEscalation.TabIndex = 2;
            this.lblEscalation.Text = "label13";
            this.lblEscalation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(20, 37);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(41, 13);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "label12";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(680, 37);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label11";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 401);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1180, 49);
            this.panel4.TabIndex = 2;
            // 
            // pnlBudgetHeader
            // 
            this.pnlBudgetHeader.Controls.Add(this.label17);
            this.pnlBudgetHeader.Controls.Add(this.label19);
            this.pnlBudgetHeader.Controls.Add(this.cmbFacility);
            this.pnlBudgetHeader.Controls.Add(this.label18);
            this.pnlBudgetHeader.Controls.Add(this.label16);
            this.pnlBudgetHeader.Controls.Add(this.label15);
            this.pnlBudgetHeader.Controls.Add(this.label14);
            this.pnlBudgetHeader.Controls.Add(this.Facilty);
            this.pnlBudgetHeader.Controls.Add(this.cmbCommodityDesc);
            this.pnlBudgetHeader.Controls.Add(this.cmbAllocation);
            this.pnlBudgetHeader.Controls.Add(this.cmbTotal);
            this.pnlBudgetHeader.Controls.Add(this.cmbCommodity);
            this.pnlBudgetHeader.Controls.Add(this.cmbFacilityDesc);
            this.pnlBudgetHeader.Controls.Add(this.cmbPackage);
            this.pnlBudgetHeader.Controls.Add(this.label12);
            this.pnlBudgetHeader.Controls.Add(this.label11);
            this.pnlBudgetHeader.Controls.Add(this.Qty);
            this.pnlBudgetHeader.Controls.Add(this.label10);
            this.pnlBudgetHeader.Controls.Add(this.label9);
            this.pnlBudgetHeader.Controls.Add(this.label8);
            this.pnlBudgetHeader.Controls.Add(this.label7);
            this.pnlBudgetHeader.Controls.Add(this.label6);
            this.pnlBudgetHeader.Controls.Add(this.label5);
            this.pnlBudgetHeader.Controls.Add(this.label4);
            this.pnlBudgetHeader.Controls.Add(this.label3);
            this.pnlBudgetHeader.Controls.Add(this.label2);
            this.pnlBudgetHeader.Controls.Add(this.label1);
            this.pnlBudgetHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBudgetHeader.Location = new System.Drawing.Point(0, 60);
            this.pnlBudgetHeader.Name = "pnlBudgetHeader";
            this.pnlBudgetHeader.Size = new System.Drawing.Size(1180, 89);
            this.pnlBudgetHeader.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(64, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 69;
            this.label17.Text = "Package";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(988, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 71;
            this.label19.Text = "Allocation";
            // 
            // cmbFacility
            // 
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.Location = new System.Drawing.Point(178, 26);
            this.cmbFacility.Name = "cmbFacility";
            this.cmbFacility.Size = new System.Drawing.Size(121, 21);
            this.cmbFacility.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(832, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 70;
            this.label18.Text = "Total Cost";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(623, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "Commodity Description";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(516, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "Commodity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Facilty Description";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // Facilty
            // 
            this.Facilty.AutoSize = true;
            this.Facilty.Location = new System.Drawing.Point(220, 7);
            this.Facilty.Name = "Facilty";
            this.Facilty.Size = new System.Drawing.Size(37, 13);
            this.Facilty.TabIndex = 65;
            this.Facilty.Text = "Facilty";
            // 
            // cmbCommodityDesc
            // 
            this.cmbCommodityDesc.FormattingEnabled = true;
            this.cmbCommodityDesc.Location = new System.Drawing.Point(602, 26);
            this.cmbCommodityDesc.Name = "cmbCommodityDesc";
            this.cmbCommodityDesc.Size = new System.Drawing.Size(157, 21);
            this.cmbCommodityDesc.TabIndex = 64;
            // 
            // cmbAllocation
            // 
            this.cmbAllocation.FormattingEnabled = true;
            this.cmbAllocation.Location = new System.Drawing.Point(949, 26);
            this.cmbAllocation.Name = "cmbAllocation";
            this.cmbAllocation.Size = new System.Drawing.Size(121, 21);
            this.cmbAllocation.TabIndex = 63;
            // 
            // cmbTotal
            // 
            this.cmbTotal.FormattingEnabled = true;
            this.cmbTotal.Location = new System.Drawing.Point(790, 26);
            this.cmbTotal.Name = "cmbTotal";
            this.cmbTotal.Size = new System.Drawing.Size(121, 21);
            this.cmbTotal.TabIndex = 62;
            // 
            // cmbCommodity
            // 
            this.cmbCommodity.FormattingEnabled = true;
            this.cmbCommodity.Location = new System.Drawing.Point(512, 26);
            this.cmbCommodity.Name = "cmbCommodity";
            this.cmbCommodity.Size = new System.Drawing.Size(66, 21);
            this.cmbCommodity.TabIndex = 60;
            // 
            // cmbFacilityDesc
            // 
            this.cmbFacilityDesc.FormattingEnabled = true;
            this.cmbFacilityDesc.Location = new System.Drawing.Point(334, 26);
            this.cmbFacilityDesc.Name = "cmbFacilityDesc";
            this.cmbFacilityDesc.Size = new System.Drawing.Size(157, 21);
            this.cmbFacilityDesc.TabIndex = 59;
            this.cmbFacilityDesc.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // cmbPackage
            // 
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(29, 26);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(121, 21);
            this.cmbPackage.TabIndex = 58;
            this.cmbPackage.TextChanged += new System.EventHandler(this.CmbPackage_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(860, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Allocated";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(782, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Package";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Qty
            // 
            this.Qty.Location = new System.Drawing.Point(35, 68);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(32, 13);
            this.Qty.TabIndex = 55;
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(63, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Hours";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(153, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Curr";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(666, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(599, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Escalation";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(532, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Distribs";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(465, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Labour";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(398, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Freight";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(331, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Materials";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(264, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Vendor Reps";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(197, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Equipment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(1180, 60);
            this.pnlFormTitle.TabIndex = 0;
            // 
            // frmBudgetMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBudgetMaintenance";
            this.Text = "Budget Maintenance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBudgetMaintenance_FormClosing);
            this.Load += new System.EventHandler(this.FrmBudgetMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            this.dataRepeater1.ResumeLayout(false);
            this.pnlBudgetHeader.ResumeLayout(false);
            this.pnlBudgetHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlBudgetHeader;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblMaterials;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.Label lblLabour;
        private System.Windows.Forms.Label lblDistribs;
        private System.Windows.Forms.Label lblEscalation;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCommodityDescription;
        private System.Windows.Forms.Label lblCommodity;
        private System.Windows.Forms.Label lblFacilityDescription;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckAllocation;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbFacility;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Facilty;
        private System.Windows.Forms.ComboBox cmbCommodityDesc;
        private System.Windows.Forms.ComboBox cmbAllocation;
        private System.Windows.Forms.ComboBox cmbTotal;
        private System.Windows.Forms.ComboBox cmbCommodity;
        private System.Windows.Forms.ComboBox cmbFacilityDesc;
        private System.Windows.Forms.ComboBox cmbPackage;
    }
}