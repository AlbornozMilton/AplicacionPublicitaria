using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class ItemsFuentes : Form
	{
		private IItem _Item;

		public ItemsFuentes(IItem pItem)
		{
			InitializeComponent();
			_Item = pItem;
		}

		private void ItemsFuentes_Load(object sender, EventArgs e)
		{
			fechaDateTimePicker.MinDate = DateTime.Now;
			fechaDateTimePicker.Value = DateTime.Now;
		}
	}
}
