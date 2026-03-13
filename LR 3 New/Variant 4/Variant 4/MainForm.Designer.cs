namespace Variant_4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MedicinesListBox = new System.Windows.Forms.ListBox();
            this.MedPictureBox = new System.Windows.Forms.PictureBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.QuantityLable = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.BasketRichTextBox = new System.Windows.Forms.RichTextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.ExpirationLabel = new System.Windows.Forms.Label();
            this.SuppLabel = new System.Windows.Forms.Label();
            this.ManufacLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicinesListBox
            // 
            this.MedicinesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MedicinesListBox.FormattingEnabled = true;
            this.MedicinesListBox.ItemHeight = 16;
            this.MedicinesListBox.Location = new System.Drawing.Point(0, 0);
            this.MedicinesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedicinesListBox.Name = "MedicinesListBox";
            this.MedicinesListBox.Size = new System.Drawing.Size(169, 554);
            this.MedicinesListBox.TabIndex = 0;
            this.MedicinesListBox.SelectedIndexChanged += new System.EventHandler(this.MedicinesListBox_SelectedIndexChanged);
            // 
            // MedPictureBox
            // 
            this.MedPictureBox.Location = new System.Drawing.Point(463, 0);
            this.MedPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedPictureBox.Name = "MedPictureBox";
            this.MedPictureBox.Size = new System.Drawing.Size(604, 289);
            this.MedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MedPictureBox.TabIndex = 1;
            this.MedPictureBox.TabStop = false;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(177, 107);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(125, 25);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Стоимость:";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(177, 254);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(165, 25);
            this.ManufacturerLabel.TabIndex = 3;
            this.ManufacturerLabel.Text = "Производитель:";
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpirationDateLabel.Location = new System.Drawing.Point(177, 158);
            this.ExpirationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(154, 25);
            this.ExpirationDateLabel.TabIndex = 4;
            this.ExpirationDateLabel.Text = "Срок годности:";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplierLabel.Location = new System.Drawing.Point(177, 206);
            this.SupplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(123, 25);
            this.SupplierLabel.TabIndex = 5;
            this.SupplierLabel.Text = "Поставщик:";
            // 
            // QuantityLable
            // 
            this.QuantityLable.AutoSize = true;
            this.QuantityLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityLable.Location = new System.Drawing.Point(493, 436);
            this.QuantityLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLable.Name = "QuantityLable";
            this.QuantityLable.Size = new System.Drawing.Size(123, 25);
            this.QuantityLable.TabIndex = 7;
            this.QuantityLable.Text = "Количество";
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.Location = new System.Drawing.Point(864, 457);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(163, 54);
            this.OrderButton.TabIndex = 8;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(176, 0);
            this.GroupComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(160, 24);
            this.GroupComboBox.TabIndex = 9;
            this.GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox_SelectedIndexChanged);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(623, 439);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(118, 22);
            this.QuantityTextBox.TabIndex = 10;
            // 
            // BasketRichTextBox
            // 
            this.BasketRichTextBox.Location = new System.Drawing.Point(176, 367);
            this.BasketRichTextBox.Name = "BasketRichTextBox";
            this.BasketRichTextBox.Size = new System.Drawing.Size(274, 187);
            this.BasketRichTextBox.TabIndex = 11;
            this.BasketRichTextBox.Text = "";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(309, 114);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 16);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Label1";
            // 
            // ExpirationLabel
            // 
            this.ExpirationLabel.AutoSize = true;
            this.ExpirationLabel.Location = new System.Drawing.Point(338, 165);
            this.ExpirationLabel.Name = "ExpirationLabel";
            this.ExpirationLabel.Size = new System.Drawing.Size(44, 16);
            this.ExpirationLabel.TabIndex = 13;
            this.ExpirationLabel.Text = "label2";
            // 
            // SuppLabel
            // 
            this.SuppLabel.AutoSize = true;
            this.SuppLabel.Location = new System.Drawing.Point(307, 213);
            this.SuppLabel.Name = "SuppLabel";
            this.SuppLabel.Size = new System.Drawing.Size(44, 16);
            this.SuppLabel.TabIndex = 14;
            this.SuppLabel.Text = "label3";
            // 
            // ManufacLabel
            // 
            this.ManufacLabel.AutoSize = true;
            this.ManufacLabel.Location = new System.Drawing.Point(349, 261);
            this.ManufacLabel.Name = "ManufacLabel";
            this.ManufacLabel.Size = new System.Drawing.Size(44, 16);
            this.ManufacLabel.TabIndex = 15;
            this.ManufacLabel.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(177, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Описание:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(298, 315);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(44, 16);
            this.DescriptionLabel.TabIndex = 17;
            this.DescriptionLabel.Text = "label4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManufacLabel);
            this.Controls.Add(this.SuppLabel);
            this.Controls.Add(this.ExpirationLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.BasketRichTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.QuantityLable);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.ExpirationDateLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.MedPictureBox);
            this.Controls.Add(this.MedicinesListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лекарственные средства";
            ((System.ComponentModel.ISupportInitialize)(this.MedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MedicinesListBox;
        private System.Windows.Forms.PictureBox MedPictureBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Label QuantityLable;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.RichTextBox BasketRichTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label ExpirationLabel;
        private System.Windows.Forms.Label SuppLabel;
        private System.Windows.Forms.Label ManufacLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}

