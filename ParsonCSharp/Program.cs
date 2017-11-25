using System;

namespace ParsonCSharp
{
    class Program
    {
        static void print(string a, string b, string c, string d)
        {
            Console.WriteLine(a + "\n\t" + b + "\n\t\t" + c + "\n\t\t\t" + d);
        }
        static void Main(string[] args)
        {
            var root_value = parson.json_value_init_object();
            var root_obj = parson.json_value_get_object(root_value);

            string jsonSTR = "";
            using (var wv = new System.Net.WebClient()) {
                jsonSTR = wv.DownloadString("http://mysafeinfo.com/api/data?list=englishmonarchs&format=json");

                if(jsonSTR.Length != 0)
                {
                    var jsonOBJ = parson.json_parse_string(jsonSTR);
                    var jsonARR = parson.json_value_get_array(jsonOBJ);

                    for(int i = 0; i < parson.json_array_get_count(jsonARR); i++)
                    {
                        var person = parson.json_array_get_object(jsonARR, Convert.ToUInt32(i));
                        

                        print(parson.json_object_get_string(person, "nm"),parson.json_object_get_string(person, "cty"),parson.json_object_get_string(person, "hse"),parson.json_object_get_string(person, "yrs"));
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
