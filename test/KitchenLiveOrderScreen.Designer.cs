﻿namespace test
{
    partial class KitchenLiveOrderScreen
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
            this.preparingListBox = new System.Windows.Forms.ListBox();
            this.preparingLabel = new System.Windows.Forms.Label();
            this.foodReadyListBox = new System.Windows.Forms.ListBox();
            this.collectionReadyLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.outDeliveryListBox = new System.Windows.Forms.Label();
            this.rdyCollectionButton = new System.Windows.Forms.Button();
            this.outDeliveryButton = new System.Windows.Forms.Button();
            this.returnPrepFromColButton = new System.Windows.Forms.Button();
            this.returnPrepFromDelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // preparingListBox
            // 
            this.preparingListBox.FormattingEnabled = true;
            this.preparingListBox.Location = new System.Drawing.Point(46, 144);
            this.preparingListBox.Name = "preparingListBox";
            this.preparingListBox.Size = new System.Drawing.Size(346, 550);
            this.preparingListBox.TabIndex = 0;
            // 
            // preparingLabel
            // 
            this.preparingLabel.AutoSize = true;
            this.preparingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.preparingLabel.Location = new System.Drawing.Point(64, 99);
            this.preparingLabel.Name = "preparingLabel";
            this.preparingLabel.Size = new System.Drawing.Size(141, 33);
            this.preparingLabel.TabIndex = 1;
            this.preparingLabel.Text = "Preparing";
            // 
            // foodReadyListBox
            // 
            this.foodReadyListBox.FormattingEnabled = true;
            this.foodReadyListBox.Location = new System.Drawing.Point(544, 90);
            this.foodReadyListBox.Name = "foodReadyListBox";
            this.foodReadyListBox.Size = new System.Drawing.Size(551, 251);
            this.foodReadyListBox.TabIndex = 2;
            // 
            // collectionReadyLabel
            // 
            this.collectionReadyLabel.AutoSize = true;
            this.collectionReadyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionReadyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.collectionReadyLabel.Location = new System.Drawing.Point(556, 44);
            this.collectionReadyLabel.Name = "collectionReadyLabel";
            this.collectionReadyLabel.Size = new System.Drawing.Size(288, 33);
            this.collectionReadyLabel.TabIndex = 3;
            this.collectionReadyLabel.Text = "Ready For Collection";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(544, 428);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(551, 277);
            this.listBox1.TabIndex = 4;
            // 
            // outDeliveryListBox
            // 
            this.outDeliveryListBox.AutoSize = true;
            this.outDeliveryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outDeliveryListBox.ForeColor = System.Drawing.SystemColors.Control;
            this.outDeliveryListBox.Location = new System.Drawing.Point(556, 382);
            this.outDeliveryListBox.Name = "outDeliveryListBox";
            this.outDeliveryListBox.Size = new System.Drawing.Size(229, 33);
            this.outDeliveryListBox.TabIndex = 5;
            this.outDeliveryListBox.Text = "Out For Delivery";
            // 
            // rdyCollectionButton
            // 
            this.rdyCollectionButton.Location = new System.Drawing.Point(428, 190);
            this.rdyCollectionButton.Name = "rdyCollectionButton";
            this.rdyCollectionButton.Size = new System.Drawing.Size(75, 67);
            this.rdyCollectionButton.TabIndex = 6;
            this.rdyCollectionButton.Text = ">";
            this.rdyCollectionButton.UseVisualStyleBackColor = true;
            // 
            // outDeliveryButton
            // 
            this.outDeliveryButton.Location = new System.Drawing.Point(428, 522);
            this.outDeliveryButton.Name = "outDeliveryButton";
            this.outDeliveryButton.Size = new System.Drawing.Size(75, 67);
            this.outDeliveryButton.TabIndex = 7;
            this.outDeliveryButton.Text = ">";
            this.outDeliveryButton.UseVisualStyleBackColor = true;
            // 
            // returnPrepFromColButton
            // 
            this.returnPrepFromColButton.Location = new System.Drawing.Point(428, 263);
            this.returnPrepFromColButton.Name = "returnPrepFromColButton";
            this.returnPrepFromColButton.Size = new System.Drawing.Size(75, 56);
            this.returnPrepFromColButton.TabIndex = 8;
            this.returnPrepFromColButton.Text = "<";
            this.returnPrepFromColButton.UseVisualStyleBackColor = true;
            // 
            // returnPrepFromDelButton
            // 
            this.returnPrepFromDelButton.Location = new System.Drawing.Point(428, 595);
            this.returnPrepFromDelButton.Name = "returnPrepFromDelButton";
            this.returnPrepFromDelButton.Size = new System.Drawing.Size(75, 57);
            this.returnPrepFromDelButton.TabIndex = 9;
            this.returnPrepFromDelButton.Text = "<";
            this.returnPrepFromDelButton.UseVisualStyleBackColor = true;
            // 
            // KitchenLiveOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.returnPrepFromDelButton);
            this.Controls.Add(this.returnPrepFromColButton);
            this.Controls.Add(this.outDeliveryButton);
            this.Controls.Add(this.rdyCollectionButton);
            this.Controls.Add(this.outDeliveryListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.collectionReadyLabel);
            this.Controls.Add(this.foodReadyListBox);
            this.Controls.Add(this.preparingLabel);
            this.Controls.Add(this.preparingListBox);
            this.Name = "KitchenLiveOrderScreen";
            this.Text = "KitchenLiveOrderScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox preparingListBox;
        private System.Windows.Forms.Label preparingLabel;
        private System.Windows.Forms.ListBox foodReadyListBox;
        private System.Windows.Forms.Label collectionReadyLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label outDeliveryListBox;
        private System.Windows.Forms.Button rdyCollectionButton;
        private System.Windows.Forms.Button outDeliveryButton;
        private System.Windows.Forms.Button returnPrepFromColButton;
        private System.Windows.Forms.Button returnPrepFromDelButton;
    }
}