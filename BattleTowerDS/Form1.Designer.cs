namespace BattleTowerDS
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TrainerClass = new TextBox();
            label2 = new Label();
            TrainerName = new TextBox();
            label3 = new Label();
            PokemonName = new TextBox();
            PokemonsView = new DataGridView();
            PokemonsViewBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)PokemonsView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PokemonsViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "肩書き：";
            // 
            // TrainerClass
            // 
            TrainerClass.Location = new Point(70, 6);
            TrainerClass.Name = "TrainerClass";
            TrainerClass.Size = new Size(140, 23);
            TrainerClass.TabIndex = 1;
            TrainerClass.TextChanged += TrainerClass_TextChanged;
            TrainerClass.Enter += TrainerClass_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "名前：";
            // 
            // TrainerName
            // 
            TrainerName.Location = new Point(288, 6);
            TrainerName.Name = "TrainerName";
            TrainerName.Size = new Size(140, 23);
            TrainerName.TabIndex = 3;
            TrainerName.TextChanged += TrainerName_TextChanged;
            TrainerName.Enter += TrainerName_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 9);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "ポケモン：";
            // 
            // PokemonName
            // 
            PokemonName.Location = new Point(529, 6);
            PokemonName.Name = "PokemonName";
            PokemonName.Size = new Size(140, 23);
            PokemonName.TabIndex = 5;
            PokemonName.TextChanged += PokemonName_TextChanged;
            PokemonName.Enter += PokemonName_Enter;
            // 
            // PokemonsView
            // 
            PokemonsView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PokemonsView.AutoGenerateColumns = false;
            PokemonsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PokemonsView.DataSource = PokemonsViewBindingSource;
            PokemonsView.Location = new Point(12, 35);
            PokemonsView.Name = "PokemonsView";
            PokemonsView.RowTemplate.Height = 25;
            PokemonsView.Size = new Size(920, 454);
            PokemonsView.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(PokemonsView);
            Controls.Add(PokemonName);
            Controls.Add(label3);
            Controls.Add(TrainerName);
            Controls.Add(label2);
            Controls.Add(TrainerClass);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PokemonsView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PokemonsViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TrainerClass;
        private Label label2;
        private TextBox TrainerName;
        private Label label3;
        private TextBox PokemonName;
        private DataGridView PokemonsView;
        private BindingSource PokemonsViewBindingSource;
    }
}