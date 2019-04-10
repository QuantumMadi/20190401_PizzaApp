namespace PizzaApp.WinForms
{
    partial class OrderForm
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
            this.lstPizzas = new System.Windows.Forms.ListBox();
            this.grBoxOrder = new System.Windows.Forms.GroupBox();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grBoxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPizzas
            // 
            this.lstPizzas.FormattingEnabled = true;
            this.lstPizzas.Location = new System.Drawing.Point(12, 45);
            this.lstPizzas.Name = "lstPizzas";
            this.lstPizzas.Size = new System.Drawing.Size(303, 329);
            this.lstPizzas.TabIndex = 0;
            this.lstPizzas.SelectedIndexChanged += new System.EventHandler(this.lstPizzas_SelectedIndexChanged);
            // 
            // grBoxOrder
            // 
            this.grBoxOrder.Controls.Add(this.btnRemove);
            this.grBoxOrder.Controls.Add(this.lblPrice2);
            this.grBoxOrder.Controls.Add(this.lblPrice);
            this.grBoxOrder.Controls.Add(this.btnSubmit);
            this.grBoxOrder.Controls.Add(this.lstOrder);
            this.grBoxOrder.Location = new System.Drawing.Point(415, 12);
            this.grBoxOrder.Name = "grBoxOrder";
            this.grBoxOrder.Size = new System.Drawing.Size(373, 404);
            this.grBoxOrder.TabIndex = 1;
            this.grBoxOrder.TabStop = false;
            this.grBoxOrder.Text = "Order";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Location = new System.Drawing.Point(12, 222);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(13, 13);
            this.lblPrice2.TabIndex = 3;
            this.lblPrice2.Text = "0";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 222);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(255, 360);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 38);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(6, 33);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(338, 186);
            this.lstOrder.TabIndex = 0;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(239, 225);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 30);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove ";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grBoxOrder);
            this.Controls.Add(this.lstPizzas);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.grBoxOrder.ResumeLayout(false);
            this.grBoxOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPizzas;
        private System.Windows.Forms.GroupBox grBoxOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}