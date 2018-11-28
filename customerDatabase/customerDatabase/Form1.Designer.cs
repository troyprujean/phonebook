namespace customerDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tblOuter = new System.Windows.Forms.TableLayoutPanel();
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tblLeftTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblEnterCustomerName = new System.Windows.Forms.Label();
            this.tblLeftTopInner = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tblLeftBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnListCustomers = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.tblRight = new System.Windows.Forms.TableLayoutPanel();
            this.tblRightBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.tblRightMid = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.tblOuter.SuspendLayout();
            this.tblLeft.SuspendLayout();
            this.tblLeftTop.SuspendLayout();
            this.tblLeftTopInner.SuspendLayout();
            this.tblLeftBottom.SuspendLayout();
            this.tblRight.SuspendLayout();
            this.tblRightBottom.SuspendLayout();
            this.gbxCustomerDetails.SuspendLayout();
            this.tblRightMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblOuter
            // 
            this.tblOuter.ColumnCount = 2;
            this.tblOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.Controls.Add(this.tblLeft, 0, 0);
            this.tblOuter.Controls.Add(this.tblRight, 1, 0);
            this.tblOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOuter.Location = new System.Drawing.Point(0, 0);
            this.tblOuter.Name = "tblOuter";
            this.tblOuter.RowCount = 1;
            this.tblOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.Size = new System.Drawing.Size(784, 461);
            this.tblOuter.TabIndex = 0;
            // 
            // tblLeft
            // 
            this.tblLeft.ColumnCount = 1;
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.Controls.Add(this.tblLeftTop, 0, 0);
            this.tblLeft.Controls.Add(this.tblLeftBottom, 0, 2);
            this.tblLeft.Controls.Add(this.lbxCustomers, 0, 1);
            this.tblLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeft.Location = new System.Drawing.Point(3, 3);
            this.tblLeft.Name = "tblLeft";
            this.tblLeft.RowCount = 3;
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLeft.Size = new System.Drawing.Size(386, 455);
            this.tblLeft.TabIndex = 0;
            // 
            // tblLeftTop
            // 
            this.tblLeftTop.ColumnCount = 1;
            this.tblLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeftTop.Controls.Add(this.lblEnterCustomerName, 0, 0);
            this.tblLeftTop.Controls.Add(this.tblLeftTopInner, 0, 1);
            this.tblLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeftTop.Location = new System.Drawing.Point(3, 3);
            this.tblLeftTop.Name = "tblLeftTop";
            this.tblLeftTop.RowCount = 2;
            this.tblLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLeftTop.Size = new System.Drawing.Size(380, 107);
            this.tblLeftTop.TabIndex = 0;
            // 
            // lblEnterCustomerName
            // 
            this.lblEnterCustomerName.AutoSize = true;
            this.lblEnterCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnterCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCustomerName.Location = new System.Drawing.Point(3, 0);
            this.lblEnterCustomerName.Name = "lblEnterCustomerName";
            this.lblEnterCustomerName.Size = new System.Drawing.Size(374, 42);
            this.lblEnterCustomerName.TabIndex = 0;
            this.lblEnterCustomerName.Text = "Enter Customer Name:";
            this.lblEnterCustomerName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tblLeftTopInner
            // 
            this.tblLeftTopInner.ColumnCount = 2;
            this.tblLeftTopInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLeftTopInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLeftTopInner.Controls.Add(this.txtSearch, 0, 0);
            this.tblLeftTopInner.Controls.Add(this.btnSearch, 1, 0);
            this.tblLeftTopInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeftTopInner.Location = new System.Drawing.Point(3, 45);
            this.tblLeftTopInner.Name = "tblLeftTopInner";
            this.tblLeftTopInner.RowCount = 1;
            this.tblLeftTopInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLeftTopInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLeftTopInner.Size = new System.Drawing.Size(374, 59);
            this.tblLeftTopInner.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(190, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tblLeftBottom
            // 
            this.tblLeftBottom.ColumnCount = 2;
            this.tblLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLeftBottom.Controls.Add(this.btnListCustomers, 0, 0);
            this.tblLeftBottom.Controls.Add(this.btnClearList, 1, 0);
            this.tblLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeftBottom.Location = new System.Drawing.Point(3, 389);
            this.tblLeftBottom.Name = "tblLeftBottom";
            this.tblLeftBottom.RowCount = 1;
            this.tblLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLeftBottom.Size = new System.Drawing.Size(380, 63);
            this.tblLeftBottom.TabIndex = 2;
            // 
            // btnListCustomers
            // 
            this.btnListCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCustomers.Location = new System.Drawing.Point(6, 16);
            this.btnListCustomers.Name = "btnListCustomers";
            this.btnListCustomers.Size = new System.Drawing.Size(177, 30);
            this.btnListCustomers.TabIndex = 0;
            this.btnListCustomers.Text = "LIST CUSTOMERS";
            this.btnListCustomers.UseVisualStyleBackColor = true;
            this.btnListCustomers.Click += new System.EventHandler(this.btnListCustomers_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.Location = new System.Drawing.Point(196, 16);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(177, 30);
            this.btnClearList.TabIndex = 1;
            this.btnClearList.Text = "CLEAR LIST";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 20;
            this.lbxCustomers.Location = new System.Drawing.Point(9, 116);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(367, 264);
            this.lbxCustomers.TabIndex = 1;
            this.lbxCustomers.SelectedValueChanged += new System.EventHandler(this.lbxCustomers_SelectedValueChanged);
            // 
            // tblRight
            // 
            this.tblRight.ColumnCount = 1;
            this.tblRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRight.Controls.Add(this.tblRightBottom, 0, 2);
            this.tblRight.Controls.Add(this.gbxCustomerDetails, 0, 1);
            this.tblRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRight.Location = new System.Drawing.Point(395, 3);
            this.tblRight.Name = "tblRight";
            this.tblRight.RowCount = 3;
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tblRight.Size = new System.Drawing.Size(386, 455);
            this.tblRight.TabIndex = 1;
            // 
            // tblRightBottom
            // 
            this.tblRightBottom.ColumnCount = 2;
            this.tblRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRightBottom.Controls.Add(this.btnUpdate, 0, 0);
            this.tblRightBottom.Controls.Add(this.btnAdd, 1, 0);
            this.tblRightBottom.Controls.Add(this.btnDelete, 0, 1);
            this.tblRightBottom.Controls.Add(this.btnClear, 1, 1);
            this.tblRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRightBottom.Location = new System.Drawing.Point(3, 325);
            this.tblRightBottom.Name = "tblRightBottom";
            this.tblRightBottom.RowCount = 2;
            this.tblRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRightBottom.Size = new System.Drawing.Size(380, 127);
            this.tblRightBottom.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 30);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(196, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(6, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(196, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbxCustomerDetails
            // 
            this.gbxCustomerDetails.Controls.Add(this.tblRightMid);
            this.gbxCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerDetails.Location = new System.Drawing.Point(3, 67);
            this.gbxCustomerDetails.Name = "gbxCustomerDetails";
            this.gbxCustomerDetails.Size = new System.Drawing.Size(380, 252);
            this.gbxCustomerDetails.TabIndex = 0;
            this.gbxCustomerDetails.TabStop = false;
            this.gbxCustomerDetails.Text = "Customer Details:";
            // 
            // tblRightMid
            // 
            this.tblRightMid.ColumnCount = 2;
            this.tblRightMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblRightMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblRightMid.Controls.Add(this.lblFirstName, 0, 0);
            this.tblRightMid.Controls.Add(this.lblLastName, 0, 1);
            this.tblRightMid.Controls.Add(this.lblPhone, 0, 2);
            this.tblRightMid.Controls.Add(this.txtFirstName, 1, 0);
            this.tblRightMid.Controls.Add(this.txtLastName, 1, 1);
            this.tblRightMid.Controls.Add(this.txtPhone, 1, 2);
            this.tblRightMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRightMid.Location = new System.Drawing.Point(3, 22);
            this.tblRightMid.Name = "tblRightMid";
            this.tblRightMid.RowCount = 3;
            this.tblRightMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRightMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRightMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRightMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblRightMid.Size = new System.Drawing.Size(374, 227);
            this.tblRightMid.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(50, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(51, 102);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(86, 178);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(171, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 26);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(171, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 26);
            this.txtLastName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(171, 175);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(181, 26);
            this.txtPhone.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tblOuter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblOuter.ResumeLayout(false);
            this.tblLeft.ResumeLayout(false);
            this.tblLeftTop.ResumeLayout(false);
            this.tblLeftTop.PerformLayout();
            this.tblLeftTopInner.ResumeLayout(false);
            this.tblLeftTopInner.PerformLayout();
            this.tblLeftBottom.ResumeLayout(false);
            this.tblRight.ResumeLayout(false);
            this.tblRightBottom.ResumeLayout(false);
            this.gbxCustomerDetails.ResumeLayout(false);
            this.tblRightMid.ResumeLayout(false);
            this.tblRightMid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblOuter;
        private System.Windows.Forms.TableLayoutPanel tblLeft;
        private System.Windows.Forms.TableLayoutPanel tblRight;
        private System.Windows.Forms.TableLayoutPanel tblLeftTop;
        private System.Windows.Forms.TableLayoutPanel tblLeftBottom;
        private System.Windows.Forms.TableLayoutPanel tblRightBottom;
        private System.Windows.Forms.Label lblEnterCustomerName;
        private System.Windows.Forms.TableLayoutPanel tblLeftTopInner;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.Button btnListCustomers;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbxCustomerDetails;
        private System.Windows.Forms.TableLayoutPanel tblRightMid;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
    }
}

