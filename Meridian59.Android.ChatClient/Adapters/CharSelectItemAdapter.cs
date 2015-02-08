﻿/*
 Copyright (c) 2012-2013 Clint Banzhaf
 This file is part of "Meridian59 .NET".

 "Meridian59 .NET" is free software: 
 You can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, 
 either version 3 of the License, or (at your option) any later version.

 "Meridian59 .NET" is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 See the GNU General Public License for more details.

 You should have received a copy of the GNU General Public License along with "Meridian59 .NET".
 If not, see http://www.gnu.org/licenses/.
*/

using Android.Widget;
using Android.Views;
using Android.App;
using System.ComponentModel;
using Meridian59.Data.Models;
using Meridian59.Data.Lists;

namespace Meridian59.Android.ChatClient.Adapters
{
    /// <summary>
    /// Adapter for character selection items
    /// </summary>
    public class CharSelectItemAdapter : BaseAdapter<CharSelectItem>
    {
        protected Activity context;
        protected readonly CharSelectItem[] items;

        public CharSelectItemAdapter(CharSelectItem[] Chat, Activity Activity)
            : base()
        {
            items = Chat;
            context = Activity;
        }

        public override CharSelectItem this[int position]
        {
            get { return items[position]; }
        }

        public override int Count
        {
            get { return items.Length; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            CharSelectItem item = items[position];
            View view = convertView;
            
            if (convertView == null || !(convertView is LinearLayout))
                view = context.LayoutInflater.Inflate(Resource.Layout.CharSelectItemView, parent, false);

            TextView text = view.FindViewById<TextView>(Resource.Id.charSelectItem);
            text.Text = item.Name;

            return view;
        }
    }
}
