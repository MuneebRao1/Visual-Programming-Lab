namespace PizzaOrderForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.checkBoxCheese = new System.Windows.Forms.CheckBox();
            this.checkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.radioButtonThinCrust = new System.Windows.Forms.RadioButton();
            this.radioButtonThickCrust = new System.Windows.Forms.RadioButton();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.labelOrderSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.comboBoxSize.Location = new System.Drawing.Point(20, 20);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSize.TabIndex = 0;
            // 
            // checkBoxCheese
            // 
            this.checkBoxCheese.AutoSize = true;
            this.checkBoxCheese.Location = new System.Drawing.Point(20, 60);
            this.checkBoxCheese.Name = "checkBoxCheese";
            this.checkBoxCheese.Size = new System.Drawing.Size(86, 24);
            this.checkBoxCheese.TabIndex = 1;
            this.checkBoxCheese.Text = "Cheese";
            this.checkBoxCheese.UseVisualStyleBackColor = true;
            // 
            // checkBoxPepperoni
            // 
            this.checkBoxPepperoni.AutoSize = true;
            this.checkBoxPepperoni.Location = new System.Drawing.Point(20, 90);
            this.checkBoxPepperoni.Name = "checkBoxPepperoni";
            this.checkBoxPepperoni.Size = new System.Drawing.Size(103, 24);
            this.checkBoxPepperoni.TabIndex = 2;
            this.checkBoxPepperoni.Text = "Pepperoni";
            this.checkBoxPepperoni.UseVisualStyleBackColor = true;
            // 
            // checkBoxMushrooms
            // 
            this.checkBoxMushrooms.AutoSize = true;
            this.checkBoxMushrooms.Location = new System.Drawing.Point(20, 120);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(110, 24);
            this.checkBoxMushrooms.TabIndex = 3;
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            // 
            // radioButtonThinCrust
            // 
            this.radioButtonThinCrust.AutoSize = true;
            this.radioButtonThinCrust.Location = new System.Drawing.Point(20, 160);
            this.radioButtonThinCrust.Name = "radioButtonThinCrust";
            this.radioButtonThinCrust.Size = new System.Drawing.Size(101, 24);
            this.radioButtonThinCrust.TabIndex = 4;
            this.radioButtonThinCrust.TabStop = true;
            this.radioButtonThinCrust.Text = "Thin Crust";
            this.radioButtonThinCrust.UseVisualStyleBackColor = true;
            // 
            // radioButtonThickCrust
            // 
            this.radioButtonThickCrust.AutoSize = true;
            this.radioButtonThickCrust.Location = new System.Drawing.Point(20, 190);
            this.radioButtonThickCrust.Name = "radioButtonThickCrust";
            this.radioButtonThickCrust.Size = new System.Drawing.Size(109, 24);
            this.radioButtonThickCrust.TabIndex = 5;
            this.radioButtonThickCrust.TabStop = true;
            this.radioButtonThickCrust.Text = "Thick Crust";
            this.radioButtonThickCrust.UseVisualStyleBackColor = true;
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Location = new System.Drawing.Point(20, 230);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(200, 35);
            this.buttonPlaceOrder.TabIndex = 6;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // labelOrderSummary
            // 
            this.labelOrderSummary.AutoSize = true;
            this.labelOrderSummary.Location = new System.Drawing.Point(20, 280);
            this.labelOrderSummary.Name = "labelOrderSummary";
            this.labelOrderSummary.Size = new System.Drawing.Size(0, 20);
            this.labelOrderSummary.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.labelOrderSummary);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.radioButtonThickCrust);
            this.Controls.Add(this.radioButtonThinCrust);
            this.Controls.Add(this.checkBoxMushrooms);
            this.Controls.Add(this.checkBoxPepperoni);
            this.Controls.Add(this.checkBoxCheese);
            this.Controls.Add(this.comboBoxSize);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.CheckBox checkBoxCheese;
        private System.Windows.Forms.CheckBox checkBoxPepperoni;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.RadioButton radioButtonThinCrust;
        private System.Windows.Forms.RadioButton radioButtonThickCrust;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Label labelOrderSummary;
    }
}
