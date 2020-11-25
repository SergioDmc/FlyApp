using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FlyApp
{
    public class preferences
    {
        public string profile;
        public bool markerTooltipActive;
        public int view;
        public double zoom, initLAT, initLNG;
        public enum markerColor
        {
            def = 0,
            red = 1,
            blue = 2,
            green = 3,
            black = 4,
            yellow = 5
        }

        public markerColor marColor;

        public preferences(string p, bool m, int v, double z, double ilat, double ilng, markerColor c)
        {
            profile = p;
            markerTooltipActive = m;
            view = v;
            zoom = z;
            initLAT = ilat;
            initLNG = ilng;
            marColor = c;
           
        }
    }

    public class dbPreferences<T>
    {
        public List<T> prefValues = new List<T>();
        public string route;

        public dbPreferences(string r)
        {
            route = r;
        }

        public void save()
        {
            string text = JsonConvert.SerializeObject(prefValues);
            File.WriteAllText(route,text);
        }

        public void load()
        {
            try
            {
                string archive = File.ReadAllText(route);
                prefValues = JsonConvert.DeserializeObject<List<T>>(archive);
            }
            catch (Exception) { }
        }
        public void insert(T New)
        {
            prefValues.Add(New);
            save();
        }
        public List<T> Search(Func<T,bool> flag)
        {
            return prefValues.Where(flag).ToList();
        }
        public void delete(Func<T, bool> flag)
        {
            prefValues = prefValues.Where(x => !flag(x)).ToList();
        }
        public void refresh(Func<T, bool> flag, T New)
        {
            prefValues = prefValues.Select(x =>
            {
                if (flag(x)) 
                    x = New;
                return x;
            }).ToList();
            save();
        }
    }
}
