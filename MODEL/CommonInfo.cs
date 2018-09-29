using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace MODEL
{
    public class CommonInfo
    {
        public enum Types
        {
           权限,
        }
        public static  int  权限 = 0;
        public static  int  人员管理 = 1;
        public static  int  显示管理 = 2;
        public static  int  启动 = 3;
        public static  int  配置管理 = 4;
        public static  int  人员删除 = 5;
        public static  int  人员新增 = 6;
        public static  int  人员修改 = 7;
        public static  int  区域设置 = 8;
        public static  int  显示设置 = 9;
        public static  int  列表顺序设置 = 10;
        public static  int  开始 = 11;
        public static  int  停止 = 12;
        public static  int  配置新增 = 13;
        public static  int  配置修改 = 14;
        public static  int  配置删除 = 15;
        public static  int  新增类别 = 16;
        public static  int  编号设置 = 17;
        public static int 区域新增 = 18;
        public static int 区域修改 = 19;
        public static int 区域删除=20;
        public static int 编号新增=21;
        public static int 编号修改 = 22;
        public static int 编号删除 = 23;
        public static int 显示新增 = 24;
        public static int 显示修改 = 25;
        public static int 显示删除 = 26;
        public static int 显示器设置 = 27;
        public static int 显示器新增 = 28;
        public static int 显示器修改 = 29;
        public static int 显示器删除 = 30;

        public static string ChangesToJson(string jsonKey)
        {
            string json = "{\"Name\" : \"Jack\", \"Age\" : 34, \"Colleagues\" : [{\"Name\" : \"Tom\" , \"Age\":44},{\"Name\" : \"Abel\",\"Age\":29}] }";
            JObject jObj = JObject.Parse(json);
            JToken ageToken = jObj["Age"];
            Console.WriteLine(ageToken.ToString());

            //将json转换为JObject
            JObject jObj1 = JObject.Parse(json);
            var names = from staff in jObj1["Colleagues"].Children() //Children() 可以返回所有数组中的对象
                        select (string)staff["Name"];
            foreach (var name in names)
                Console.WriteLine(name);

            //删除
            JObject jObj2 = JObject.Parse(json);
            jObj2.Remove("Colleagues");//跟的是属性名称
            Console.WriteLine(jObj2.ToString());

            return ageToken.ToString();
        }
    }
}
