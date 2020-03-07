﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FaceUnlockVocalNode
{
    public class CustomAdapter : BaseAdapter<Note>
    {
        List<Note> items;
        private Activity context;
        public CustomAdapter(Activity context, List<Note> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override Note this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.home, null);
            view.FindViewById<TextView>(Resource.Id.titoloNota).Text = item.getTitolo();
            view.FindViewById<TextView>(Resource.Id.dataNota).Text = item.getData();
            view.FindViewById<Button>(Resource.Id.elimina).Text = "Cancella";
            view.FindViewById<Button>(Resource.Id.elimina).SetTag(1, item.getId_nota());
            return view;
        }



      
    }
    }