namespace Zadan5
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label номер_зачетки_Label;
            System.Windows.Forms.Label семестрLabel;
            System.Windows.Forms.Label дисциплинаLabel;
            System.Windows.Forms.Label оценкаLabel;
            System.Windows.Forms.Label дата_сдачиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newDatabaseDataSet = new Zadan5.NewDatabaseDataSet();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradesTableAdapter = new Zadan5.NewDatabaseDataSetTableAdapters.GradesTableAdapter();
            this.tableAdapterManager = new Zadan5.NewDatabaseDataSetTableAdapters.TableAdapterManager();
            this.gradesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gradesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.newDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номер_зачетки_ComboBox = new System.Windows.Forms.ComboBox();
            this.gradesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.семестрTextBox = new System.Windows.Forms.TextBox();
            this.дисциплинаTextBox = new System.Windows.Forms.TextBox();
            this.оценкаTextBox = new System.Windows.Forms.TextBox();
            this.дата_сдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            номер_зачетки_Label = new System.Windows.Forms.Label();
            семестрLabel = new System.Windows.Forms.Label();
            дисциплинаLabel = new System.Windows.Forms.Label();
            оценкаLabel = new System.Windows.Forms.Label();
            дата_сдачиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingNavigator)).BeginInit();
            this.gradesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_зачетки_Label
            // 
            номер_зачетки_Label.AutoSize = true;
            номер_зачетки_Label.BackColor = System.Drawing.Color.White;
            номер_зачетки_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            номер_зачетки_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            номер_зачетки_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_зачетки_Label.Location = new System.Drawing.Point(28, 121);
            номер_зачетки_Label.Name = "номер_зачетки_Label";
            номер_зачетки_Label.Size = new System.Drawing.Size(139, 20);
            номер_зачетки_Label.TabIndex = 11;
            номер_зачетки_Label.Text = "Номер зачетки :";
            // 
            // семестрLabel
            // 
            семестрLabel.AutoSize = true;
            семестрLabel.BackColor = System.Drawing.Color.White;
            семестрLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            семестрLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            семестрLabel.Location = new System.Drawing.Point(71, 152);
            семестрLabel.Name = "семестрLabel";
            семестрLabel.Size = new System.Drawing.Size(83, 20);
            семестрLabel.TabIndex = 13;
            семестрLabel.Text = "Семестр:";
            // 
            // дисциплинаLabel
            // 
            дисциплинаLabel.AutoSize = true;
            дисциплинаLabel.BackColor = System.Drawing.Color.White;
            дисциплинаLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            дисциплинаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дисциплинаLabel.Location = new System.Drawing.Point(57, 180);
            дисциплинаLabel.Name = "дисциплинаLabel";
            дисциплинаLabel.Size = new System.Drawing.Size(110, 20);
            дисциплинаLabel.TabIndex = 15;
            дисциплинаLabel.Text = "Дисциплина:";
            // 
            // оценкаLabel
            // 
            оценкаLabel.AutoSize = true;
            оценкаLabel.BackColor = System.Drawing.Color.White;
            оценкаLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            оценкаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            оценкаLabel.Location = new System.Drawing.Point(71, 208);
            оценкаLabel.Name = "оценкаLabel";
            оценкаLabel.Size = new System.Drawing.Size(73, 20);
            оценкаLabel.TabIndex = 17;
            оценкаLabel.Text = "Оценка:";
            // 
            // дата_сдачиLabel
            // 
            дата_сдачиLabel.AutoSize = true;
            дата_сдачиLabel.BackColor = System.Drawing.Color.White;
            дата_сдачиLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            дата_сдачиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_сдачиLabel.Location = new System.Drawing.Point(62, 239);
            дата_сдачиLabel.Name = "дата_сдачиLabel";
            дата_сдачиLabel.Size = new System.Drawing.Size(105, 20);
            дата_сдачиLabel.TabIndex = 19;
            дата_сдачиLabel.Text = "Дата сдачи:";
            // 
            // newDatabaseDataSet
            // 
            this.newDatabaseDataSet.DataSetName = "NewDatabaseDataSet";
            this.newDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "Grades";
            this.gradesBindingSource.DataSource = this.newDatabaseDataSet;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GradesTableAdapter = this.gradesTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zadan5.NewDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gradesBindingNavigator
            // 
            this.gradesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gradesBindingNavigator.BindingSource = this.gradesBindingSource;
            this.gradesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gradesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gradesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gradesBindingNavigatorSaveItem});
            this.gradesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gradesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gradesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gradesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gradesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gradesBindingNavigator.Name = "gradesBindingNavigator";
            this.gradesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gradesBindingNavigator.Size = new System.Drawing.Size(464, 27);
            this.gradesBindingNavigator.TabIndex = 0;
            this.gradesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // gradesBindingNavigatorSaveItem
            // 
            this.gradesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gradesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gradesBindingNavigatorSaveItem.Image")));
            this.gradesBindingNavigatorSaveItem.Name = "gradesBindingNavigatorSaveItem";
            this.gradesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.gradesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.gradesBindingNavigatorSaveItem.Click += new System.EventHandler(this.gradesBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Оценки";
            // 
            // newDatabaseDataSetBindingSource
            // 
            this.newDatabaseDataSetBindingSource.DataSource = this.newDatabaseDataSet;
            this.newDatabaseDataSetBindingSource.Position = 0;
            // 
            // номер_зачетки_ComboBox
            // 
            this.номер_зачетки_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gradesBindingSource, "Номер зачетки ", true));
            this.номер_зачетки_ComboBox.DataSource = this.gradesBindingSource1;
            this.номер_зачетки_ComboBox.DisplayMember = "Номер зачетки ";
            this.номер_зачетки_ComboBox.FormattingEnabled = true;
            this.номер_зачетки_ComboBox.Location = new System.Drawing.Point(193, 121);
            this.номер_зачетки_ComboBox.Name = "номер_зачетки_ComboBox";
            this.номер_зачетки_ComboBox.Size = new System.Drawing.Size(200, 24);
            this.номер_зачетки_ComboBox.TabIndex = 12;
            this.номер_зачетки_ComboBox.ValueMember = "Номер зачетки ";
            // 
            // gradesBindingSource1
            // 
            this.gradesBindingSource1.DataMember = "Grades";
            this.gradesBindingSource1.DataSource = this.newDatabaseDataSet;
            // 
            // семестрTextBox
            // 
            this.семестрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gradesBindingSource, "Семестр", true));
            this.семестрTextBox.Location = new System.Drawing.Point(193, 152);
            this.семестрTextBox.Name = "семестрTextBox";
            this.семестрTextBox.Size = new System.Drawing.Size(200, 22);
            this.семестрTextBox.TabIndex = 14;
            // 
            // дисциплинаTextBox
            // 
            this.дисциплинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gradesBindingSource, "Дисциплина", true));
            this.дисциплинаTextBox.Location = new System.Drawing.Point(193, 180);
            this.дисциплинаTextBox.Name = "дисциплинаTextBox";
            this.дисциплинаTextBox.Size = new System.Drawing.Size(200, 22);
            this.дисциплинаTextBox.TabIndex = 16;
            // 
            // оценкаTextBox
            // 
            this.оценкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gradesBindingSource, "Оценка", true));
            this.оценкаTextBox.Location = new System.Drawing.Point(193, 208);
            this.оценкаTextBox.Name = "оценкаTextBox";
            this.оценкаTextBox.Size = new System.Drawing.Size(200, 22);
            this.оценкаTextBox.TabIndex = 18;
            // 
            // дата_сдачиDateTimePicker
            // 
            this.дата_сдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gradesBindingSource, "Дата сдачи", true));
            this.дата_сдачиDateTimePicker.Location = new System.Drawing.Point(193, 236);
            this.дата_сдачиDateTimePicker.Name = "дата_сдачиDateTimePicker";
            this.дата_сдачиDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_сдачиDateTimePicker.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(347, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Список";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(347, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 334);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(номер_зачетки_Label);
            this.Controls.Add(this.номер_зачетки_ComboBox);
            this.Controls.Add(семестрLabel);
            this.Controls.Add(this.семестрTextBox);
            this.Controls.Add(дисциплинаLabel);
            this.Controls.Add(this.дисциплинаTextBox);
            this.Controls.Add(оценкаLabel);
            this.Controls.Add(this.оценкаTextBox);
            this.Controls.Add(дата_сдачиLabel);
            this.Controls.Add(this.дата_сдачиDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Оценки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingNavigator)).EndInit();
            this.gradesBindingNavigator.ResumeLayout(false);
            this.gradesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NewDatabaseDataSet newDatabaseDataSet;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private NewDatabaseDataSetTableAdapters.GradesTableAdapter gradesTableAdapter;
        private NewDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gradesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gradesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource newDatabaseDataSetBindingSource;
        private System.Windows.Forms.ComboBox номер_зачетки_ComboBox;
        private System.Windows.Forms.BindingSource gradesBindingSource1;
        private System.Windows.Forms.TextBox семестрTextBox;
        private System.Windows.Forms.TextBox дисциплинаTextBox;
        private System.Windows.Forms.TextBox оценкаTextBox;
        private System.Windows.Forms.DateTimePicker дата_сдачиDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

