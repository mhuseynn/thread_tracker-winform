namespace ThreadTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            workinglist = new ListView();
            waitinglist = new ListView();
            createdlist = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            counter = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)counter).BeginInit();
            SuspendLayout();
            // 
            // workinglist
            // 
            workinglist.Location = new Point(51, 108);
            workinglist.Name = "workinglist";
            workinglist.Size = new Size(185, 194);
            workinglist.TabIndex = 0;
            workinglist.UseCompatibleStateImageBehavior = false;
            workinglist.View = View.SmallIcon;
            // 
            // waitinglist
            // 
            waitinglist.Location = new Point(304, 108);
            waitinglist.Name = "waitinglist";
            waitinglist.Size = new Size(185, 194);
            waitinglist.TabIndex = 1;
            waitinglist.UseCompatibleStateImageBehavior = false;
            waitinglist.View = View.SmallIcon;
            // 
            // createdlist
            // 
            createdlist.Location = new Point(549, 108);
            createdlist.Name = "createdlist";
            createdlist.Size = new Size(185, 194);
            createdlist.TabIndex = 2;
            createdlist.UseCompatibleStateImageBehavior = false;
            createdlist.View = View.SmallIcon;
            createdlist.MouseDoubleClick += createdlist_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 68);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 3;
            label1.Text = "Worker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 68);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Waiting";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(613, 66);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 5;
            label3.Text = "Created";
            // 
            // button1
            // 
            button1.Location = new Point(576, 323);
            button1.Name = "button1";
            button1.Size = new Size(127, 50);
            button1.TabIndex = 6;
            button1.Text = "Create Thread";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // counter
            // 
            counter.Location = new Point(51, 372);
            counter.Name = "counter";
            counter.Size = new Size(150, 27);
            counter.TabIndex = 8;
            counter.ValueChanged += counter_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 338);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 9;
            label4.Text = "Places in Semaphore";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(counter);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(createdlist);
            Controls.Add(waitinglist);
            Controls.Add(workinglist);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)counter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView workinglist;
        private ListView waitinglist;
        private ListView createdlist;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private NumericUpDown counter;
        private Label label4;
    }
}