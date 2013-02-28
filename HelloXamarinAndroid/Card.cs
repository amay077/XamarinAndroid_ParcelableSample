
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;

namespace HelloXamarinAndroid
{
    class Card : Java.Lang.Object, IParcelable
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Card(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        #region IParcelable implementation

        public int DescribeContents()
        {
            return 0;
        }

        public void WriteToParcel(Parcel dest, ParcelableWriteFlags flags)
        {
            dest.WriteString(this.Name);
            dest.WriteString(this.Phone);
        }

        #endregion

        [ExportField("CREATOR")]
        public static IParcelableCreator GetCreator()
        {
            return new MyParcelableCreator();
        }

        // Parcelable.Creator 
        class MyParcelableCreator : Java.Lang.Object, IParcelableCreator
        {
            #region IParcelableCreator implementation
            Java.Lang.Object IParcelableCreator.CreateFromParcel(Parcel source)
            {
                var name = source.ReadString();
                var phone = source.ReadString();

                return new Card(name, phone);
            }

            Java.Lang.Object[] IParcelableCreator.NewArray(int size)
            {
                return new Java.Lang.Object[size];
            }
            #endregion
        }
    }
}

