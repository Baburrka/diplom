namespace Diplom
{
    partial class Matrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matrix));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saharny_diabetDataSet1 = new Diplom.Saharny_diabetDataSet1();
            this.матрица_весовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.матрица_весовTableAdapter1 = new Diplom.Saharny_diabetDataSet1TableAdapters.Матрица_весовTableAdapter();
            this.tableAdapterManager1 = new Diplom.Saharny_diabetDataSet1TableAdapters.TableAdapterManager();
            this.матрица_весовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.матрица_весовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.матрица_весовBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сонливость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.saharny_diabetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_весовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_весовBindingNavigator)).BeginInit();
            this.матрица_весовBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_весовBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // saharny_diabetDataSet1
            // 
            this.saharny_diabetDataSet1.DataSetName = "Saharny_diabetDataSet1";
            this.saharny_diabetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // матрица_весовBindingSource
            // 
            this.матрица_весовBindingSource.DataMember = "Матрица весов";
            this.матрица_весовBindingSource.DataSource = this.saharny_diabetDataSet1;
            // 
            // матрица_весовTableAdapter1
            // 
            this.матрица_весовTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Diplom.Saharny_diabetDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Матрица_весовTableAdapter = this.матрица_весовTableAdapter1;
            this.tableAdapterManager1.ПациентыTableAdapter = null;
            // 
            // матрица_весовBindingNavigator
            // 
            this.матрица_весовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.матрица_весовBindingNavigator.BindingSource = this.матрица_весовBindingSource;
            this.матрица_весовBindingNavigator.CountItem = null;
            this.матрица_весовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.матрица_весовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.матрица_весовBindingNavigatorSaveItem});
            this.матрица_весовBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.матрица_весовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.матрица_весовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.матрица_весовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.матрица_весовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.матрица_весовBindingNavigator.Name = "матрица_весовBindingNavigator";
            this.матрица_весовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.матрица_весовBindingNavigator.Size = new System.Drawing.Size(387, 25);
            this.матрица_весовBindingNavigator.TabIndex = 0;
            this.матрица_весовBindingNavigator.Text = "bindingNavigator1";
            this.матрица_весовBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // матрица_весовBindingNavigatorSaveItem
            // 
            this.матрица_весовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.матрица_весовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("матрица_весовBindingNavigatorSaveItem.Image")));
            this.матрица_весовBindingNavigatorSaveItem.Name = "матрица_весовBindingNavigatorSaveItem";
            this.матрица_весовBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.матрица_весовBindingNavigatorSaveItem.Text = "Save Data";
            this.матрица_весовBindingNavigatorSaveItem.Click += new System.EventHandler(this.матрица_весовBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать веса";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RaschetVesov_Click);
            // 
            // матрица_весовBindingSource1
            // 
            this.матрица_весовBindingSource1.DataMember = "Матрица весов";
            this.матрица_весовBindingSource1.DataSource = this.saharny_diabetDataSet1;
            // 
            // dgv1
            // 
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Сонливость,
            this.dataGridViewTextBoxColumn5});
            this.dgv1.DataSource = this.матрица_весовBindingSource1;
            this.dgv1.Location = new System.Drawing.Point(12, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 130;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Size = new System.Drawing.Size(464, 172);
            this.dgv1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Мочеиспускание";
            this.dataGridViewTextBoxColumn1.HeaderText = "Мочеиспускание";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Жажда";
            this.dataGridViewTextBoxColumn2.HeaderText = "Жажда";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Аппетит";
            this.dataGridViewTextBoxColumn3.HeaderText = "Аппетит";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // Сонливость
            // 
            this.Сонливость.DataPropertyName = "Сонливость";
            this.Сонливость.HeaderText = "Сонливость";
            this.Сонливость.Name = "Сонливость";
            this.Сонливость.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Зрение";
            this.dataGridViewTextBoxColumn5.HeaderText = "Зрение";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // Matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 220);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.матрица_весовBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Matrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрица весов";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saharny_diabetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_весовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_весовBindingNavigator)).EndInit();
            this.матрица_весовBindingNavigator.ResumeLayout(false);
            this.матрица_весовBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_весовBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Saharny_diabetDataSet1 saharny_diabetDataSet1;
        private System.Windows.Forms.BindingSource матрица_весовBindingSource;
        private Saharny_diabetDataSet1TableAdapters.Матрица_весовTableAdapter матрица_весовTableAdapter1;
        private Saharny_diabetDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator матрица_весовBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton матрица_весовBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        //private Saharny_diabetDataSet1 saharny_diabetDataSet1;
        private System.Windows.Forms.BindingSource матрица_весовBindingSource1;
        //private Saharny_diabetDataSet1TableAdapters.Матрица_весовTableAdapter матрица_весовTableAdapter1;
        //private Saharny_diabetDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сонливость;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}