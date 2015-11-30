using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using ClassLibrary.Winform.UI.Common;

namespace ClassLibrary.Winform.UI.Controls
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(System.Windows.Forms.DateTimePicker))]
    public class DateTimePicker : System.Windows.Forms.DateTimePicker
    {
        /// <summary>
        /// �Ƿ���������Ϊ��
        /// </summary>
        private Boolean m_AllowDateNull = false;
        /// <summary>
        /// ��ȡ�������Ƿ���������Ϊ��
        /// </summary>
        [Browsable(true), 
        Category(ControlManager.CustomPropertyCategory), 
        Description("������Backspace��Delete��ťʱ���Ƿ���������Ϊ�գ�Textֵ��")]
        public Boolean AllowDateNull
        {
            get { return this.m_AllowDateNull; }
            set { this.m_AllowDateNull = value; }
        }

        public DateTimePicker()
            : base()
        {
            base.MinDate = Convert.ToDateTime("1980-01-01");
            base.MaxDate = Convert.ToDateTime("2100-01-01");

            base.Format = DateTimePickerFormat.Custom;
            base.CustomFormat = " ";
            base.Text = string.Empty;
        }

        public DateTimePicker(IContainer container)
            : this()
        {
            if (container != null)
            {
                container.Add(this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            //if (this.m_AllowDateNull)
            //{
                if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                {
                    base.Format = DateTimePickerFormat.Custom;
                    //����Ҫ����
                    base.CustomFormat = " ";
                    // OnValueChanged(EventArgs.Empty);
                }
            //}
            base.OnKeyUp(e);
        }
        /// <summary>
        /// ���رտؼ�ʱ
        /// </summary>
        /// <param name="eventargs"></param>
        protected override void OnCloseUp(EventArgs eventargs)
        {
            //if (this.m_AllowDateNull)
            //{
                base.Format = DateTimePickerFormat.Custom;
                base.CustomFormat = "yyyy-MM-dd";
            //}
            base.OnCloseUp(eventargs);
        }

        /// <summary>
        /// ���ÿؼ��ı�
        /// </summary>
        /// <param name="text"></param>
        private void SetText(string text)
        {
            if (text != "")
            {
                base.Format = DateTimePickerFormat.Long;

                base.Text = text;
            }
            else
            {
                base.Format = DateTimePickerFormat.Custom;
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    //this.Format = DateTimePickerFormat.Custom;
                    base.CustomFormat = " ";
                }
                else
                {
                    //this.Format = DateTimePickerFormat.Long;
                    base.CustomFormat = "yyyy-MM-dd";
                }

                base.Text = value;
            }
        }
    }
}
