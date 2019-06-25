using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nits.Model;
using System.Net.Http;
using NITS.API;

/// <summary>
/// Summary description for StockItemBLL
/// </summary>
public class StockItemBLL
{
    public List<StockItem> getStockItem()
    {
        HttpClient hc = NitsAPI.apiConnection1();
        HttpResponseMessage response = hc.GetAsync("StockItem").Result;
        List<StockItem> SList = response.Content.ReadAsAsync<IEnumerable<StockItem>>().Result.ToList();
        return SList;
    }

    public string AddStockItem( List<StockItem> model)
    {
        HttpClient http = NITS.API.NitsAPI.apiConnection1();
        var ReturnMessage = http.PostAsJsonAsync("StockItem", model).Result;

        if (ReturnMessage.IsSuccessStatusCode)
        {
            return ReturnMessage.Content.ReadAsAsync<string>().Result;
        }
        else
        {
            return ReturnMessage.Content.ReadAsAsync<string>().Result;
        }
    }
    public string DeleteStockItem(long ItemID)
    {
        HttpClient http = NitsAPI.apiConnection1();
        var ReturnMessage = http.DeleteAsync("StockItem/" + ItemID.ToString()).Result;
        if (ReturnMessage.IsSuccessStatusCode)
        {
            return ReturnMessage.Content.ReadAsAsync<string>().Result;
        }
        else
        {
            return ReturnMessage.Content.ReadAsAsync<string>().Result;
        }
    }
    public StockItem EditStockItem(long ItemID)
    {
        HttpClient hc = NitsAPI.apiConnection1();

        HttpResponseMessage response = hc.GetAsync("StockItem/" + ItemID).Result;
        StockItem StmModel = response.Content.ReadAsAsync<StockItem>().Result;

        return StmModel;
    }
    public string UpdateStockItem(StockItem model)
    {
        HttpClient http = NitsAPI.apiConnection1();
        HttpResponseMessage response = http.GetAsync("StockItem/" + model.ItemID.ToString()).Result;
        List<StockItem> SList = response.Content.ReadAsAsync<IEnumerable<StockItem>>().Result.ToList();
        StockItem Smodel = SList.FirstOrDefault(x => x.ItemID == model.ItemID);
        //Smodel.ClassName = model.ClassName;
        //Smodel.SectionName = model.SectionName;
        var ReturnMessage = http.PutAsJsonAsync("StockItem", Smodel).Result;
        if (ReturnMessage.IsSuccessStatusCode)
        {
            return ReturnMessage.Content.ReadAsAsync<string>().Result;
        }
        else
        {
            return ReturnMessage.Content.ReadAsAsync<string>().Result;
        }
    }
}