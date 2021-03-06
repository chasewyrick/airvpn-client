// <airvpn_source_header>
// This file is part of AirVPN Client software.
// Copyright (C)2014-2014 AirVPN (support@airvpn.org) / https://airvpn.org )
//
// AirVPN Client is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AirVPN Client is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with AirVPN Client. If not, see <http://www.gnu.org/licenses/>.
// </airvpn_source_header>

using System;
using MonoMac.AppKit;

namespace AirVPN.UI.Osx
{
	public class TableServersDelegate : NSTableViewDelegate
	{
		MainWindowController m_main;

		public TableServersDelegate (MainWindowController main)
		{
			m_main = main;
		}

		public override void SelectionDidChange (MonoMac.Foundation.NSNotification notification)
		{
			m_main.EnabledUI ();
		}

		public override void MouseDownInHeaderOfTableColumn (NSTableView tableView, NSTableColumn tableColumn)
		{
			m_main.TableServersController.SortByColumn (tableColumn.Identifier);
		}
		/*
		public override void WillDisplayCell (NSTableView tableView, MonoMac.Foundation.NSObject cell, NSTableColumn tableColumn, int row)
		{
			if (tableColumn.Identifier == "Load") {
				NSTextFieldCell c = cell as NSTextFieldCell;
				c.TextColor = NSColor.Red;
				c.BackgroundColor = NSColor.Green;
				c.DrawsBackground = true;
			}
		}
		*/
	}
}

