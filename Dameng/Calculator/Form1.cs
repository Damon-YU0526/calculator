using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calculate
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button Subtraction;
		private System.Windows.Forms.Button Division;
		private System.Windows.Forms.Button Multiplication;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            n1 = 0;
            n2 = 0;
            fun = "";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(249, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "+";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(353, 448);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 69);
            this.button5.TabIndex = 5;
            this.button5.Text = "=";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(41, 362);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 69);
            this.button6.TabIndex = 6;
            this.button6.Text = "0";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(145, 362);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 69);
            this.button7.TabIndex = 7;
            this.button7.Text = ".";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(353, 103);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 69);
            this.button8.TabIndex = 8;
            this.button8.Text = "C";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction.Location = new System.Drawing.Point(249, 448);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(85, 69);
            this.Subtraction.TabIndex = 9;
            this.Subtraction.Text = "-";
            this.Subtraction.Click += new System.EventHandler(this.button9_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(41, 448);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(85, 69);
            this.Division.TabIndex = 10;
            this.Division.Text = "/";
            this.Division.Click += new System.EventHandler(this.button10_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication.Location = new System.Drawing.Point(145, 448);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(85, 69);
            this.Multiplication.TabIndex = 11;
            this.Multiplication.Text = "*";
            this.Multiplication.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(41, 190);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(85, 68);
            this.button12.TabIndex = 12;
            this.button12.Text = "4";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(145, 190);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(85, 68);
            this.button13.TabIndex = 13;
            this.button13.Text = "5";
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(249, 190);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(85, 68);
            this.button14.TabIndex = 14;
            this.button14.Text = "6";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(41, 276);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(85, 69);
            this.button15.TabIndex = 15;
            this.button15.Text = "7";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(145, 276);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(85, 69);
            this.button16.TabIndex = 16;
            this.button16.Text = "8";
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(249, 276);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(85, 69);
            this.button17.TabIndex = 17;
            this.button17.Text = "9";
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(13, 28);
            this.ClientSize = new System.Drawing.Size(572, 605);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
        decimal  n1, n2;
		string fun;

        /// <summary>
        /// '1' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button1_Click(object sender, System.EventArgs e)
		{
		    textBox1.Text = textBox1.Text + "1";
		}

        /// <summary>
        /// '2' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button2_Click(object sender, System.EventArgs e)
		{
		    textBox1.Text = textBox1.Text + "2";
		}

        /// <summary>
        /// '3' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button3_Click(object sender, System.EventArgs e)
		{
			textBox1.Text = textBox1.Text + "3";
		}

        /// <summary>
        /// '.' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button7_Click(object sender, System.EventArgs e)
		{
			textBox1.Text = textBox1.Text + ".";
		}

        /// <summary>
        /// '0' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button6_Click(object sender, System.EventArgs e)
		{
			textBox1.Text = textBox1.Text + "0";
		}

        /// <summary>
        /// 'c' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button8_Click(object sender, System.EventArgs e)
		{
		    textBox1.Text ="";
            n1 = n2 = 0;
            fun = "";
		}

        /// <summary>
        /// '+' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button4_Click(object sender, System.EventArgs e)
		{
            // The user might click '+' button first
            try
            {
                n1 = decimal.Parse(textBox1.Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            n1 = decimal.Parse(textBox1.Text);
            textBox1.Text ="";
            fun ="+";
		}

        /// <summary>
        /// '=' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button5_Click(object sender, System.EventArgs e)
		{
			n2 = decimal.Parse(textBox1.Text);
            if (fun == "+")
                n1 = n1 + n2;
            else
            if (fun == "-")
                n1 = n1 - n2;
            else
                if (fun == "*")
                n1 = n1 * n2;
            else
                if (fun == "/")
            {
                if (n2 == 0)
                    return;
                n1 = n1 / n2;
            }
			textBox1.Text = n1.ToString();
		}

        /// <summary>
        /// '-' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button9_Click(object sender, System.EventArgs e)
		{
            // The user might click '-' button first
            try
            {
                n1 = decimal.Parse(textBox1.Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            n1 = decimal.Parse(textBox1.Text);
			textBox1.Text = "";
			fun ="-";
		}

        /// <summary>
        /// '*' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button11_Click(object sender, System.EventArgs e)
		{
            // The user might click '*' button first
            try
            {
                n1 = decimal.Parse(textBox1.Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            n1 = decimal.Parse(textBox1.Text);
			textBox1.Text ="";
			fun ="*";
		}

        /// <summary>
        /// '4' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        /// <summary>
        /// '5' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        /// <summary>
        /// '6' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        /// <summary>
        /// '7' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        /// <summary>
        /// '8' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        /// <summary>
        /// '9' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        /// <summary>
        /// '/' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, System.EventArgs e)
		{
            // The user might click '+' button first
            try
            {
                n1 = decimal.Parse(textBox1.Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            n1 = decimal.Parse(textBox1.Text);
			textBox1.Text ="";
			fun ="/";
		}
	}
}
