using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarfaceRichPresence.Controls
{
	public enum SeparatorLineMode
	{
		Horizontal,
		Vertical
	}

	public class SeparatorLine : Label
	{
		public SeparatorLine()
		{
			AutoSize = false;
			Mode = SeparatorLineMode.Vertical;
			Height = 2;
			BorderStyle = BorderStyle.Fixed3D;
		}

		public SeparatorLineMode Mode {
			get;
			set;
		}

		public override bool AutoSize {
			get
			{
				return false;
			}
		}

		public override Size MinimumSize {
			get
			{
				if(Mode == SeparatorLineMode.Horizontal)
					return new Size(1, 2);
				else
					return new Size(2, 1);
			}
		}

		public override Size MaximumSize {
			get
			{
				if(Mode == SeparatorLineMode.Horizontal)
					return new Size(int.MaxValue, 2);
				else
					return new Size(2, int.MaxValue);
			}
		}

		public override string Text {
			get
			{
				return "";
			}
		}
	}
}
