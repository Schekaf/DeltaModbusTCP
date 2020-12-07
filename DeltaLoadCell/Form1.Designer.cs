namespace DeltaLoadCell
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.camBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrotZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGecmeZaman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.butBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGramaj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrotZ1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colencoderValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZaman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblEnc1 = new System.Windows.Forms.Label();
            this.txtC = new DevExpress.XtraEditors.TextEdit();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clients :";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(502, 305);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Gramaj";
            this.gridColumn1.FieldName = "Gramaj";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cam :";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.camBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(13, 342);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(501, 316);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // camBindingSource
            // 
            this.camBindingSource.DataSource = typeof(DeltaLoadCell.Cam);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colData,
            this.colposX,
            this.colposY,
            this.colrotZ,
            this.colAlan,
            this.colGecmeZaman});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colData
            // 
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            // 
            // colposX
            // 
            this.colposX.FieldName = "posX";
            this.colposX.Name = "colposX";
            this.colposX.Visible = true;
            this.colposX.VisibleIndex = 1;
            // 
            // colposY
            // 
            this.colposY.FieldName = "posY";
            this.colposY.Name = "colposY";
            this.colposY.Visible = true;
            this.colposY.VisibleIndex = 2;
            // 
            // colrotZ
            // 
            this.colrotZ.FieldName = "rotZ";
            this.colrotZ.Name = "colrotZ";
            this.colrotZ.Visible = true;
            this.colrotZ.VisibleIndex = 3;
            // 
            // colAlan
            // 
            this.colAlan.FieldName = "Alan";
            this.colAlan.Name = "colAlan";
            this.colAlan.Visible = true;
            this.colAlan.VisibleIndex = 4;
            // 
            // colGecmeZaman
            // 
            this.colGecmeZaman.FieldName = "GecmeZaman";
            this.colGecmeZaman.Name = "colGecmeZaman";
            this.colGecmeZaman.Visible = true;
            this.colGecmeZaman.VisibleIndex = 5;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.butBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(668, 30);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(676, 296);
            this.gridControl3.TabIndex = 5;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // butBindingSource
            // 
            this.butBindingSource.DataSource = typeof(DeltaLoadCell.But);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGramaj,
            this.colposX1,
            this.colposY1,
            this.colrotZ1,
            this.colalan1,
            this.colencoderValue,
            this.colZaman});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // colGramaj
            // 
            this.colGramaj.FieldName = "Gramaj";
            this.colGramaj.Name = "colGramaj";
            this.colGramaj.Visible = true;
            this.colGramaj.VisibleIndex = 0;
            // 
            // colposX1
            // 
            this.colposX1.FieldName = "posX";
            this.colposX1.Name = "colposX1";
            this.colposX1.Visible = true;
            this.colposX1.VisibleIndex = 1;
            // 
            // colposY1
            // 
            this.colposY1.FieldName = "posY";
            this.colposY1.Name = "colposY1";
            this.colposY1.Visible = true;
            this.colposY1.VisibleIndex = 2;
            // 
            // colrotZ1
            // 
            this.colrotZ1.FieldName = "rotZ";
            this.colrotZ1.Name = "colrotZ1";
            this.colrotZ1.Visible = true;
            this.colrotZ1.VisibleIndex = 3;
            // 
            // colalan1
            // 
            this.colalan1.FieldName = "alan";
            this.colalan1.Name = "colalan1";
            this.colalan1.Visible = true;
            this.colalan1.VisibleIndex = 4;
            // 
            // colencoderValue
            // 
            this.colencoderValue.FieldName = "encoderValue";
            this.colencoderValue.Name = "colencoderValue";
            this.colencoderValue.Visible = true;
            this.colencoderValue.VisibleIndex = 5;
            // 
            // colZaman
            // 
            this.colZaman.DisplayFormat.FormatString = "HH:mm:ss";
            this.colZaman.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colZaman.FieldName = "Zaman";
            this.colZaman.Name = "colZaman";
            this.colZaman.Visible = true;
            this.colZaman.VisibleIndex = 6;
            // 
            // lblEnc1
            // 
            this.lblEnc1.AutoSize = true;
            this.lblEnc1.Location = new System.Drawing.Point(1301, 9);
            this.lblEnc1.Name = "lblEnc1";
            this.lblEnc1.Size = new System.Drawing.Size(27, 13);
            this.lblEnc1.TabIndex = 6;
            this.lblEnc1.Text = "val1";
            // 
            // txtC
            // 
            this.txtC.EditValue = "2000";
            this.txtC.Location = new System.Drawing.Point(1177, 6);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 7;
            // 
            // gridControl4
            // 
            this.gridControl4.DataSource = this.butBindingSource;
            this.gridControl4.Location = new System.Drawing.Point(668, 365);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(676, 296);
            this.gridControl4.TabIndex = 8;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Gramaj";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "posX";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "posY";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "rotZ";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "alan";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "encoderValue";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.DisplayFormat.FormatString = "HH:mm:ss";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn8.FieldName = "Zaman";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(891, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Clients :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(980, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clients :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 670);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridControl4);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblEnc1);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource camBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colposX;
        private DevExpress.XtraGrid.Columns.GridColumn colposY;
        private DevExpress.XtraGrid.Columns.GridColumn colrotZ;
        private DevExpress.XtraGrid.Columns.GridColumn colAlan;
        private DevExpress.XtraGrid.Columns.GridColumn colGecmeZaman;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource butBindingSource;
        private System.Windows.Forms.Label lblEnc1;
        private DevExpress.XtraGrid.Columns.GridColumn colGramaj;
        private DevExpress.XtraGrid.Columns.GridColumn colposX1;
        private DevExpress.XtraGrid.Columns.GridColumn colposY1;
        private DevExpress.XtraGrid.Columns.GridColumn colrotZ1;
        private DevExpress.XtraGrid.Columns.GridColumn colalan1;
        private DevExpress.XtraGrid.Columns.GridColumn colencoderValue;
        private DevExpress.XtraGrid.Columns.GridColumn colZaman;
        private DevExpress.XtraEditors.TextEdit txtC;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

