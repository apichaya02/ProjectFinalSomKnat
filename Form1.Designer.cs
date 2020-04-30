namespace new_project
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
            System.Windows.Forms.Label รหัสนักศึกษาLabel;
            System.Windows.Forms.Label ชื่อ_นามสกุลLabel;
            System.Windows.Forms.Label สาขาLabel;
            System.Windows.Forms.Label อาการLabel;
            System.Windows.Forms.Label ยาที่รับLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database1DataSet = new new_project.Database1DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new new_project.Database1DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new new_project.Database1DataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.รหัสนักศึกษาTextBox = new System.Windows.Forms.TextBox();
            this.ชื่อ_นามสกุลTextBox = new System.Windows.Forms.TextBox();
            this.สาขาTextBox = new System.Windows.Forms.TextBox();
            this.อาการTextBox = new System.Windows.Forms.TextBox();
            this.ยาที่รับTextBox = new System.Windows.Forms.TextBox();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.รหสนกศกษาDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ชอนามสกลDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.สาขาDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.อาการDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ยาทรบDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            รหัสนักศึกษาLabel = new System.Windows.Forms.Label();
            ชื่อ_นามสกุลLabel = new System.Windows.Forms.Label();
            สาขาLabel = new System.Windows.Forms.Label();
            อาการLabel = new System.Windows.Forms.Label();
            ยาที่รับLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // รหัสนักศึกษาLabel
            // 
            รหัสนักศึกษาLabel.AutoSize = true;
            รหัสนักศึกษาLabel.Font = new System.Drawing.Font("supermarket", 15.75F, System.Drawing.FontStyle.Bold);
            รหัสนักศึกษาLabel.Location = new System.Drawing.Point(23, 32);
            รหัสนักศึกษาLabel.Name = "รหัสนักศึกษาLabel";
            รหัสนักศึกษาLabel.Size = new System.Drawing.Size(123, 37);
            รหัสนักศึกษาLabel.TabIndex = 3;
            รหัสนักศึกษาLabel.Text = "รหัสนักศึกษา:";
            // 
            // ชื่อ_นามสกุลLabel
            // 
            ชื่อ_นามสกุลLabel.AutoSize = true;
            ชื่อ_นามสกุลLabel.Font = new System.Drawing.Font("supermarket", 15.75F, System.Drawing.FontStyle.Bold);
            ชื่อ_นามสกุลLabel.Location = new System.Drawing.Point(23, 64);
            ชื่อ_นามสกุลLabel.Name = "ชื่อ_นามสกุลLabel";
            ชื่อ_นามสกุลLabel.Size = new System.Drawing.Size(120, 37);
            ชื่อ_นามสกุลLabel.TabIndex = 5;
            ชื่อ_นามสกุลLabel.Text = "ชื่อ-นามสกุล:";
            // 
            // สาขาLabel
            // 
            สาขาLabel.AutoSize = true;
            สาขาLabel.Font = new System.Drawing.Font("supermarket", 15.75F, System.Drawing.FontStyle.Bold);
            สาขาLabel.Location = new System.Drawing.Point(23, 101);
            สาขาLabel.Name = "สาขาLabel";
            สาขาLabel.Size = new System.Drawing.Size(60, 37);
            สาขาLabel.TabIndex = 7;
            สาขาLabel.Text = "สาขา:";
            // 
            // อาการLabel
            // 
            อาการLabel.AutoSize = true;
            อาการLabel.Font = new System.Drawing.Font("supermarket", 15.75F, System.Drawing.FontStyle.Bold);
            อาการLabel.Location = new System.Drawing.Point(23, 136);
            อาการLabel.Name = "อาการLabel";
            อาการLabel.Size = new System.Drawing.Size(71, 37);
            อาการLabel.TabIndex = 9;
            อาการLabel.Text = "อาการ:";
            // 
            // ยาที่รับLabel
            // 
            ยาที่รับLabel.AutoSize = true;
            ยาที่รับLabel.Font = new System.Drawing.Font("supermarket", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ยาที่รับLabel.Location = new System.Drawing.Point(19, 212);
            ยาที่รับLabel.Name = "ยาที่รับLabel";
            ยาที่รับLabel.Size = new System.Drawing.Size(76, 37);
            ยาที่รับLabel.TabIndex = 11;
            ยาที่รับLabel.Text = "ยาที่รับ:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = new_project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // รหัสนักศึกษาTextBox
            // 
            this.รหัสนักศึกษาTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "รหัสนักศึกษา", true));
            this.รหัสนักศึกษาTextBox.Location = new System.Drawing.Point(159, 44);
            this.รหัสนักศึกษาTextBox.Name = "รหัสนักศึกษาTextBox";
            this.รหัสนักศึกษาTextBox.Size = new System.Drawing.Size(261, 20);
            this.รหัสนักศึกษาTextBox.TabIndex = 4;
            this.รหัสนักศึกษาTextBox.TextChanged += new System.EventHandler(this.รหัสนักศึกษาTextBox_TextChanged);
            // 
            // ชื่อ_นามสกุลTextBox
            // 
            this.ชื่อ_นามสกุลTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ชื่อ-นามสกุล", true));
            this.ชื่อ_นามสกุลTextBox.Location = new System.Drawing.Point(159, 76);
            this.ชื่อ_นามสกุลTextBox.Name = "ชื่อ_นามสกุลTextBox";
            this.ชื่อ_นามสกุลTextBox.Size = new System.Drawing.Size(261, 20);
            this.ชื่อ_นามสกุลTextBox.TabIndex = 6;
            // 
            // สาขาTextBox
            // 
            this.สาขาTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "สาขา", true));
            this.สาขาTextBox.Location = new System.Drawing.Point(101, 113);
            this.สาขาTextBox.Name = "สาขาTextBox";
            this.สาขาTextBox.Size = new System.Drawing.Size(261, 20);
            this.สาขาTextBox.TabIndex = 8;
            // 
            // อาการTextBox
            // 
            this.อาการTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "อาการ", true));
            this.อาการTextBox.Location = new System.Drawing.Point(101, 139);
            this.อาการTextBox.Multiline = true;
            this.อาการTextBox.Name = "อาการTextBox";
            this.อาการTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.อาการTextBox.Size = new System.Drawing.Size(460, 70);
            this.อาการTextBox.TabIndex = 10;
            // 
            // ยาที่รับTextBox
            // 
            this.ยาที่รับTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ยาที่รับ", true));
            this.ยาที่รับTextBox.Location = new System.Drawing.Point(101, 224);
            this.ยาที่รับTextBox.Name = "ยาที่รับTextBox";
            this.ยาที่รับTextBox.Size = new System.Drawing.Size(170, 20);
            this.ยาที่รับTextBox.TabIndex = 12;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.รหสนกศกษาDataGridViewTextBoxColumn,
            this.ชอนามสกลDataGridViewTextBoxColumn,
            this.สาขาDataGridViewTextBoxColumn,
            this.อาการDataGridViewTextBoxColumn,
            this.ยาทรบDataGridViewTextBoxColumn});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(90, 266);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(640, 269);
            this.tableDataGridView.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // รหสนกศกษาDataGridViewTextBoxColumn
            // 
            this.รหสนกศกษาDataGridViewTextBoxColumn.DataPropertyName = "รหัสนักศึกษา";
            this.รหสนกศกษาDataGridViewTextBoxColumn.HeaderText = "รหัสนักศึกษา";
            this.รหสนกศกษาDataGridViewTextBoxColumn.Name = "รหสนกศกษาDataGridViewTextBoxColumn";
            // 
            // ชอนามสกลDataGridViewTextBoxColumn
            // 
            this.ชอนามสกลDataGridViewTextBoxColumn.DataPropertyName = "ชื่อ-นามสกุล";
            this.ชอนามสกลDataGridViewTextBoxColumn.HeaderText = "ชื่อ-นามสกุล";
            this.ชอนามสกลDataGridViewTextBoxColumn.Name = "ชอนามสกลDataGridViewTextBoxColumn";
            // 
            // สาขาDataGridViewTextBoxColumn
            // 
            this.สาขาDataGridViewTextBoxColumn.DataPropertyName = "สาขา";
            this.สาขาDataGridViewTextBoxColumn.HeaderText = "สาขา";
            this.สาขาDataGridViewTextBoxColumn.Name = "สาขาDataGridViewTextBoxColumn";
            // 
            // อาการDataGridViewTextBoxColumn
            // 
            this.อาการDataGridViewTextBoxColumn.DataPropertyName = "อาการ";
            this.อาการDataGridViewTextBoxColumn.HeaderText = "อาการ";
            this.อาการDataGridViewTextBoxColumn.Name = "อาการDataGridViewTextBoxColumn";
            // 
            // ยาทรบDataGridViewTextBoxColumn
            // 
            this.ยาทรบDataGridViewTextBoxColumn.DataPropertyName = "ยาที่รับ";
            this.ยาทรบDataGridViewTextBoxColumn.HeaderText = "ยาที่รับ";
            this.ยาทรบDataGridViewTextBoxColumn.Name = "ยาทรบDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(รหัสนักศึกษาLabel);
            this.Controls.Add(this.รหัสนักศึกษาTextBox);
            this.Controls.Add(ชื่อ_นามสกุลLabel);
            this.Controls.Add(this.ชื่อ_นามสกุลTextBox);
            this.Controls.Add(สาขาLabel);
            this.Controls.Add(this.สาขาTextBox);
            this.Controls.Add(อาการLabel);
            this.Controls.Add(this.อาการTextBox);
            this.Controls.Add(ยาที่รับLabel);
            this.Controls.Add(this.ยาที่รับTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "โปรแกรมลงชื่อห้องพยาบาล";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox รหัสนักศึกษาTextBox;
        private System.Windows.Forms.TextBox ชื่อ_นามสกุลTextBox;
        private System.Windows.Forms.TextBox สาขาTextBox;
        private System.Windows.Forms.TextBox อาการTextBox;
        private System.Windows.Forms.TextBox ยาที่รับTextBox;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn รหสนกศกษาDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ชอนามสกลDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn สาขาDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn อาการDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ยาทรบDataGridViewTextBoxColumn;
    }
}

