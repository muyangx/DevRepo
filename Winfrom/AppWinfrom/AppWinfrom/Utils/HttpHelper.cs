using AppWinfrom.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Policy;
using System.Text;

namespace AppWinfrom.Utils
{
    public static class HttpHelper
    {
        private static string _orderBaseURL = "http://zongz.xiaoai999.com/api.php";
        private static string _goods_id = "11741";


        private static RemoteCertificateValidationCallback callback = ServicePointManager.ServerCertificateValidationCallback;
        private static SecurityProtocolType pro = ServicePointManager.SecurityProtocol;

        /// <summary>
        /// 通过api获取商品信息
        /// </summary>
        /// <returns></returns>
        public static DataModel GetDataModel()
        {
            string postData = $"type=getgoods&goods_id={_goods_id}";
            return BaseRequest<DataModel>(_orderBaseURL, postData);
        }
        /// <summary>
        /// 下单接口
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Purchase GetPurchase(int selectversion,string mobile, string BIOSNum = "")
        {
            var postData = $"type=order&goods_id={_goods_id}&scvvvvv_0={selectversion}&num=1&code={BIOSNum}&mobile={mobile}&email=&P_fenzhan=23&domain=rj.1788vip.net";
            return BaseRequest<Purchase>(_orderBaseURL, postData);
        }
        /// <summary>
        /// 获取支付二维码(切换支付宝微信)
        /// </summary>
        /// <param name="order_id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static QRModel GetQR(string order_id, string type)
        {
            var postData = $"type=pay&order_id={order_id}&pay_type={type}";
            return BaseRequest<QRModel>(_orderBaseURL, postData);
        }
        /// <summary>
        /// 查询付款状态
        /// </summary>
        /// <param name="order_id"></param>
        /// <param name="BIOSNum"></param>
        public static PayStatus PayStatus(string order_id, string BIOSNum = "") {
            var postData = $"type=query&order_id={order_id}&code={BIOSNum}";
            return BaseRequest<PayStatus>(_orderBaseURL, postData);
        }
        /// <summary>
        /// 付款后查询订单信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static PayOver PayOver(string BIOSNum)
        {
            try
            {
                var postData = $"type=query_order&code={BIOSNum}&goods_id={_goods_id}";
                var res = BaseRequest<PayOver>(_orderBaseURL, postData,true);
                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// 基础POST框架
        /// </summary>
        /// <returns></returns>
        public static T BaseRequest<T>(
            string baseURL,
            string postData,
            bool isHttps = false,
            string RequestType = "POST",
            string contentType = "application/x-www-form-urlencoded; charset=utf-8")
        {
            if (isHttps)
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            }
            else
            {
                ServicePointManager.ServerCertificateValidationCallback = callback;
                ServicePointManager.SecurityProtocol = pro;
            }
            WebRequest request = HttpWebRequest.Create(baseURL);
            request.Method = RequestType;
            //使用 application/x-www-form-urlencoded
            request.ContentType = contentType;
            //要传送的內容(依字串表示)
            //將传送的字串转为 byte array
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            //告訴 server content 的长度
            request.ContentLength = byteArray.Length;
            //將 byte array 写到 request stream 中 
            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(byteArray, 0, byteArray.Length);
            }
            using (var httpResponse = (HttpWebResponse)request.GetResponse())
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var model = JsonConvert.DeserializeObject<T>(result);
                return model;
            }
        }
    }



}
