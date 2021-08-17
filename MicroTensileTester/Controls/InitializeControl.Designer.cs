
namespace MicroTensileTester.Controls
{
    partial class InitializeControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.labelCurPosName = new System.Windows.Forms.Label();
            this.labelCurPos = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonOrigin = new System.Windows.Forms.Button();
            this.labelTarget = new System.Windows.Forms.Label();
            this.numericTarget = new System.Windows.Forms.NumericUpDown();
            this.buttonMove = new System.Windows.Forms.Button();
            this.labelJog = new System.Windows.Forms.Label();
            this.panelNumeric = new System.Windows.Forms.Panel();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTarget)).BeginInit();
            this.panelNumeric.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.AutoSize = true;
            this.layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.layout.ColumnCount = 3;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.Controls.Add(this.labelCurPosName, 0, 0);
            this.layout.Controls.Add(this.labelCurPos, 0, 1);
            this.layout.Controls.Add(this.buttonHome, 2, 0);
            this.layout.Controls.Add(this.buttonOrigin, 2, 1);
            this.layout.Controls.Add(this.labelTarget, 0, 2);
            this.layout.Controls.Add(this.buttonMove, 2, 2);
            this.layout.Controls.Add(this.buttonForward, 0, 5);
            this.layout.Controls.Add(this.labelJog, 2, 4);
            this.layout.Controls.Add(this.buttonBackward, 0, 5);
            this.layout.Controls.Add(this.panelNumeric, 0, 3);
            this.layout.Controls.Add(this.comboBoxUnit, 2, 7);
            this.layout.Controls.Add(this.labelUnit, 2, 6);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Margin = new System.Windows.Forms.Padding(0);
            this.layout.Name = "layout";
            this.layout.RowCount = 7;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.Size = new System.Drawing.Size(161, 122);
            this.layout.TabIndex = 0;
            // 
            // labelCurPosName
            // 
            this.labelCurPosName.AutoSize = true;
            this.labelCurPosName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.layout.SetColumnSpan(this.labelCurPosName, 2);
            this.labelCurPosName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurPosName.Location = new System.Drawing.Point(1, 1);
            this.labelCurPosName.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurPosName.Name = "labelCurPosName";
            this.labelCurPosName.Size = new System.Drawing.Size(91, 22);
            this.labelCurPosName.TabIndex = 0;
            this.labelCurPosName.Text = "현재 위치";
            this.labelCurPosName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurPos
            // 
            this.labelCurPos.AutoSize = true;
            this.layout.SetColumnSpan(this.labelCurPos, 2);
            this.labelCurPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurPos.Location = new System.Drawing.Point(1, 24);
            this.labelCurPos.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurPos.Name = "labelCurPos";
            this.labelCurPos.Size = new System.Drawing.Size(91, 22);
            this.labelCurPos.TabIndex = 0;
            this.labelCurPos.Text = "0";
            this.labelCurPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSize = true;
            this.buttonHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHome.Location = new System.Drawing.Point(93, 1);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(67, 22);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "원점 이동";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonOrigin
            // 
            this.buttonOrigin.AutoSize = true;
            this.buttonOrigin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOrigin.Location = new System.Drawing.Point(93, 24);
            this.buttonOrigin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOrigin.Name = "buttonOrigin";
            this.buttonOrigin.Size = new System.Drawing.Size(67, 22);
            this.buttonOrigin.TabIndex = 0;
            this.buttonOrigin.Text = "영점 조정";
            this.buttonOrigin.UseVisualStyleBackColor = true;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.layout.SetColumnSpan(this.labelTarget, 2);
            this.labelTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTarget.Location = new System.Drawing.Point(1, 47);
            this.labelTarget.Margin = new System.Windows.Forms.Padding(0);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(91, 12);
            this.labelTarget.TabIndex = 0;
            this.labelTarget.Text = "지정 모드";
            this.labelTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericTarget
            // 
            this.numericTarget.AutoSize = true;
            this.numericTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTarget.Location = new System.Drawing.Point(0, 0);
            this.numericTarget.Margin = new System.Windows.Forms.Padding(0);
            this.numericTarget.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericTarget.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericTarget.Name = "numericTarget";
            this.numericTarget.Size = new System.Drawing.Size(91, 21);
            this.numericTarget.TabIndex = 0;
            this.numericTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericTarget.ThousandsSeparator = true;
            // 
            // buttonMove
            // 
            this.buttonMove.AutoSize = true;
            this.buttonMove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMove.Location = new System.Drawing.Point(93, 47);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMove.Name = "buttonMove";
            this.layout.SetRowSpan(this.buttonMove, 2);
            this.buttonMove.Size = new System.Drawing.Size(67, 26);
            this.buttonMove.TabIndex = 0;
            this.buttonMove.Text = "이동";
            this.buttonMove.UseVisualStyleBackColor = true;
            // 
            // labelJog
            // 
            this.labelJog.AutoSize = true;
            this.labelJog.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.layout.SetColumnSpan(this.labelJog, 3);
            this.labelJog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelJog.Location = new System.Drawing.Point(1, 75);
            this.labelJog.Margin = new System.Windows.Forms.Padding(0);
            this.labelJog.Name = "labelJog";
            this.labelJog.Size = new System.Drawing.Size(159, 12);
            this.labelJog.TabIndex = 0;
            this.labelJog.Text = "조그 모드";
            this.labelJog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNumeric
            // 
            this.layout.SetColumnSpan(this.panelNumeric, 2);
            this.panelNumeric.Controls.Add(this.numericTarget);
            this.panelNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNumeric.Location = new System.Drawing.Point(1, 60);
            this.panelNumeric.Margin = new System.Windows.Forms.Padding(0);
            this.panelNumeric.Name = "panelNumeric";
            this.panelNumeric.Size = new System.Drawing.Size(91, 13);
            this.panelNumeric.TabIndex = 0;
            // 
            // buttonBackward
            // 
            this.buttonBackward.AutoSize = true;
            this.buttonBackward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBackward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBackward.Location = new System.Drawing.Point(1, 88);
            this.buttonBackward.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackward.Name = "buttonBackward";
            this.layout.SetRowSpan(this.buttonBackward, 2);
            this.buttonBackward.Size = new System.Drawing.Size(39, 33);
            this.buttonBackward.TabIndex = 0;
            this.buttonBackward.Text = "뒤로";
            this.buttonBackward.UseVisualStyleBackColor = true;
            // 
            // buttonForward
            // 
            this.buttonForward.AutoSize = true;
            this.buttonForward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonForward.Location = new System.Drawing.Point(41, 88);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(0);
            this.buttonForward.Name = "buttonForward";
            this.layout.SetRowSpan(this.buttonForward, 2);
            this.buttonForward.Size = new System.Drawing.Size(51, 33);
            this.buttonForward.TabIndex = 0;
            this.buttonForward.Text = "앞으로";
            this.buttonForward.UseVisualStyleBackColor = true;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUnit.Location = new System.Drawing.Point(93, 101);
            this.comboBoxUnit.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(67, 20);
            this.comboBoxUnit.TabIndex = 0;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUnit.Location = new System.Drawing.Point(93, 88);
            this.labelUnit.Margin = new System.Windows.Forms.Padding(0);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(67, 12);
            this.labelUnit.TabIndex = 0;
            this.labelUnit.Text = "단위";
            this.labelUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitializeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.layout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InitializeControl";
            this.Size = new System.Drawing.Size(161, 122);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTarget)).EndInit();
            this.panelNumeric.ResumeLayout(false);
            this.panelNumeric.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label labelCurPosName;
        private System.Windows.Forms.Label labelCurPos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonOrigin;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.NumericUpDown numericTarget;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label labelJog;
        private System.Windows.Forms.Panel panelNumeric;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label labelUnit;
    }
}
