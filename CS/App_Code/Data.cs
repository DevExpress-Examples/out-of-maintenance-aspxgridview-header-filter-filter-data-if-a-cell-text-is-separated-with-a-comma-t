using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Data {
    public int ID { get; set; }
    public string Cities { get; set; }
    public static List<Data> GetData() {
        List<Data> data = new List<Data>();
        data.Add(new Data() { ID = 1, Cities = "Anchorage,Berlin,Saint Louis" });
        data.Add(new Data() { ID = 2, Cities = "Berlin,Boston,Geneva" });
        data.Add(new Data() { ID = 3, Cities = "London" });
        return data;
    }
}