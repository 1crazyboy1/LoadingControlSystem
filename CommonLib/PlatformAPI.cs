using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLib.util;
using CommonLib.bean;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace CommonLib
{
    /// <summary>
    /// 
    /// </summary>
    public class PlatformAPI
    {
        string url;
        private HttpUtil httpUtil = new HttpUtil();


        private string callType = "4";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="urlPath"></param>
        /// <param name="type"></param>
        public PlatformAPI(string urlPath,string type)
        {
            this.url = urlPath;
            callType = type;
        }

        private string ImageCommon<T>(T icm, string userid)
        {

                ApiJson<T> api = new ApiJson<T>();
                CommonParameters cmp = new CommonParameters();
                cmp.userId = userid;
                cmp.callSource = "";
                cmp.callType = callType;
                cmp.callTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                cmp.key = StringToMD5Util.StringToMD5("@#!tr2017!#$" + cmp.callTime);

                api.head = cmp;
                api.body = icm;
                api.sign = "trapi20170107";
                string str = JsonConvert.SerializeObject(api);
                api.sign = StringToMD5Util.StringToMD5(str);
                string js = JsonConvert.SerializeObject(api);
                js = js.Replace("+", "%2B");
                return js;
            
        }
        private string Common<T>(T icm, string userid)
        {
                ApiJson<T> api = new ApiJson<T>();
                CommonParameters cmp = new CommonParameters();
                cmp.userId = userid;
                cmp.callSource = "";
                cmp.callType = callType;
                cmp.callTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                cmp.key = StringToMD5Util.StringToMD5("@#!tr2017!#$" + cmp.callTime);
                api.head = cmp;
                api.body = icm;
                api.sign = "trapi20170107";
                string str = JsonConvert.SerializeObject(api);
                api.sign = StringToMD5Util.StringToMD5(str);
                string js = JsonConvert.SerializeObject(api);
                return js;            
        }
        
        /// <summary>
        /// 用户登录接口
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">登录密码</param>
        /// <returns></returns>
        public Result<User> Login(string name,string pwd,string syscode)
        {
            try
            {
                RequestUser user = new RequestUser();
                user.account = name;
                user.pswd = StringToMD5Util.StringToMD5(pwd);
                user.subSystemCode = syscode;
                string strjson = httpUtil.post(url + "/api/system/login", Common<RequestUser>(user, ""));
                Result<User> res = JsonConvert.DeserializeObject<Result<User>>(strjson);
                return res;
            }
            catch (WebException e)
            {
                throw e;
            }                 
        }
        
        /// <summary>
        /// 绑定RFID标签与车辆号
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<bool> BindingRFIDWithLorryNum(RFIDTag tag,string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/vehicle/vehicleCard", Common<RFIDTag>(tag, userid));
                Result<bool> res = JsonConvert.DeserializeObject<Result<bool>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
            
        }
        /// <summary>
        /// 通过IC卡序号查询车辆信息
        /// </summary>
        /// <param name="cardno">ic卡序号</param>
        /// <returns></returns>
        public Result<CarMessage> QueryVehicleByCard(CarCardMsg cardno)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/vehicle/queryVehicleByCard", Common<CarCardMsg>(cardno, ""));
                Result<CarMessage> res = JsonConvert.DeserializeObject<Result<CarMessage>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///通过卡序号、卡面编号、卡类型 注册IC卡
        /// </summary>
        /// <param name="ic"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<bool> ICCardRegister(ICCardReg ic,string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/card/icCardReg", Common<ICCardReg>(ic, userid));
                Result<bool> res = JsonConvert.DeserializeObject<Result<bool>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
           
        }

        /// <summary>
        /// 注册RFID
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<bool> RFIDTagRegister(RFIDTag tag,string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/card/rfidReg", Common<RFIDTag>(tag, userid));
                Result<bool> res = JsonConvert.DeserializeObject<Result<bool>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }

          }

        /// <summary>
        /// 验证车辆信息
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<bool> LorryVerification(RFIDTag tag , string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/vehicle/vehicleCheck", Common<RFIDTag>(tag, userid));
                Result<bool> res = JsonConvert.DeserializeObject<Result<bool>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
           
        }

        /// <summary>
        /// 通过传入RFID序号和车牌号，获得通知单详情
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid">用户ID</param>
        /// <returns></returns>
        public Result<DeliveryOrder> getDeliveryOrder(RFIDTag tag, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/piSalesArrive/detail", Common<RFIDTag>(tag, userid));
                Result<DeliveryOrder> res = JsonConvert.DeserializeObject<Result<DeliveryOrder>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 门禁记录
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> postGateRecordApiJson(GateData ar, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/doorSystem/record", Common<GateData>(ar, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }                    
        }

        /// <summary>
        /// 入厂验证
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> EnteringVerification(RFIDTag tag, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/doorSystem/enterFactoryCheck", Common<RFIDTag>(tag, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }        
        }

        /// <summary>
        /// 出厂验证
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> ExitingVerification(RFIDTag tag,string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/doorSystem/leaveFactoryCheck", Common<RFIDTag>(tag, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
           
        }

        /// <summary>
        /// 通过传入物料，包装类型、RFID序号和车牌号获得小票信息（票号、排队车辆数）
        /// </summary>
        /// <param name="materiel"></param>
        /// <param name="userid">用户ID</param>
        /// <returns></returns>
        public Result<PrintTicket> getSmallTicketApiJson(Material mat, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/doorSystem/queueNumberhj", Common<Material>(mat, userid));
                Result<PrintTicket> res = JsonConvert.DeserializeObject<Result<PrintTicket>>(strJson);
                return res; 
            }
            catch (WebException ex)
            {
                throw ex;
            }
                         
        }

        /// <summary>
        /// 监控中心获取销售包装物料
        /// </summary>
        /// <param name="item">RFID、车牌号</param>
        /// <param name="userid">用户ID</param>
        /// <returns></returns>
        public List<MaterialInfo> getBagMaterielArray(string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/dc/materiel/getBagsMateriel", Common<object>(null, userid));
                Result<object> res = JsonConvert.DeserializeObject<Result<object>>(strJson);
                List<MaterialInfo> res1 = JsonConvert.DeserializeObject<Result<List<MaterialInfo>>>(strJson).returnData.ToList<MaterialInfo>();
                return res1;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 图片上传接口
        /// </summary>
        /// <param name="path">图片路径</param>
        /// <param name="userid">用户ID</param>
        /// <returns></returns>
        public Result<string> PostImageApiJson(string path, string userid, Image objImage)
        {
            try
            {
                FileStream files = new FileStream(path, FileMode.Open);
                byte[] imgByte = new byte[files.Length];
                objImage.FileByte = imgByte;

                files.Read(imgByte, 0, imgByte.Length);
                files.Close();
                string strJson = httpUtil.post(url + "/api/upload/image", ImageCommon<Image>(objImage, userid));

                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;   
            }
            catch (WebException ex)
            {
                throw ex;
            }
                     
        }


       

        /// <summary>
        /// 历史皮重查询
        /// </summary>
        /// <param name="tare"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string[]> getHistroyTareWeightApiJson(RequestTareWeight tare, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/poundNote/history/tareWeight", Common<RequestTareWeight>(tare, userid));
                Result<string[]> res = JsonConvert.DeserializeObject<Result<string[]>>(strJson);
                return res; 
            }
            catch (WebException ex)
            {
                throw ex;
            }
                      
        }

        /// <summary>
        /// 签收详情
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<SignDetail> QuerySignDetail(RFIDTag tag, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/poundNote/querySignDetail", Common<RFIDTag>(tag, userid));
                Result<SignDetail> detail = JsonConvert.DeserializeObject<Result<SignDetail>>(strJson);
                return detail;
            }
            catch (WebException ex)
            {
                throw ex;
            }
           
        }


        /// <summary>
        /// 获取磅单信息
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<PoundDetail> getPoundOrderFromFC(string service ,string noticCode, string userid)
        {
            try
            {
                ReqPoundDetail pd = new ReqPoundDetail();
                pd.servicetype = service;
                pd.notionformcode = noticCode;
                string strJson = httpUtil.post(url + "/api/poundNote/queryPountNote", Common<ReqPoundDetail>(pd, userid));
                Result<PoundDetail> res = JsonConvert.DeserializeObject<Result<PoundDetail>>(strJson);
                return res;   
            }
            catch (WebException ex)
            {
                throw ex;
            }                 
        }

        /// <summary>
        /// 磅单上传
        /// </summary>
        /// <param name="pound"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> postPoundOrder(PoundOrder pound, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/poundNote/up/weight", Common<PoundOrder>(pound, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
           
        }

        /// <summary>
        /// IC卡校验
        /// </summary>
        /// <param name="cardno"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<ICValidate> ICCardValidate(string cardno, string userid)
        {
            try
            {
                ICCard iccard = new ICCard();
                iccard.cardno = cardno;
                string strJson = httpUtil.post(url + "/api/card/validate ", Common<ICCard>(iccard, userid));
                Result<ICValidate> res = JsonConvert.DeserializeObject<Result<ICValidate>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }            
        }

        /// <summary>
        /// 临时标签解绑
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> RfidUnBind(RFIDTag tag,string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/card/unBindRfid", Common<RFIDTag>(tag, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        public Result<bool> Lorry_ICUnBind(string lorrynum,string userid)
        {
            try
            {
                RequestVehicle lorry = new RequestVehicle();
                lorry.vehicleNo = lorrynum;
                string strJson = httpUtil.post(url + "/api/card/unBindVeIc", Common<RequestVehicle>(lorry, userid));
                Result<bool> res = JsonConvert.DeserializeObject<Result<bool>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 查询RFID标签类型
        /// </summary>
        /// <param name="rfid"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<ResultRFIDType> QueryRFIDType(string rfid,string userid)
        {
            try
            {
                RequestRFID reqRFID= new RequestRFID();
                reqRFID.rfid = rfid;
                string strJson = httpUtil.post(url+"/api/card/rfidTypeQuery",Common<RequestRFID>(reqRFID,userid));
                Result<ResultRFIDType> res = JsonConvert.DeserializeObject<Result<ResultRFIDType>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        

        /// <summary>
        /// 红外被挡异常申请接口
        /// </summary>
        /// <param name="infraEx"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> InfraExceptionApply(InfraException infraEx,string userid)
        {
            try
            {
                string strJsno = httpUtil.post(url + "/api/exceptionAudit/apply", Common<InfraException>(infraEx,userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJsno);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            } 
        }
        
        /// <summary>
        /// 红外被挡查询接口
        /// </summary>
        /// <param name="exId"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> InfraExceptionQuery(string exId,string userid)
        {
            try
            {
                RequestInfraQuery infraQuery = new RequestInfraQuery();
                infraQuery.id = exId;
                string strJsno = httpUtil.post(url + "/api/exceptionAudit/query", Common <RequestInfraQuery>(infraQuery,userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJsno);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

      
        /// <summary>
        /// 查询车辆详情
        /// </summary>
        /// <param name="lorry"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<VehicleDetail> QueryVehicleDetail(string lorry,string userid)
        {
            try
            {
                RequestVehicle rv = new RequestVehicle();
                rv.vehicleNo = lorry;
                string strJsno = httpUtil.post(url + "/api/vehicle/vehicleDetail", Common<RequestVehicle>(rv, userid));
                Result<VehicleDetail> res = JsonConvert.DeserializeObject<Result<VehicleDetail>>(strJsno);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 皮重异常申请接口
        /// </summary>
        /// <param name="apply"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> TareWeightExceptionApply(TareWeightApply apply,string userid)
        {
            try
            {
                string strJsno = httpUtil.post(url + "/api/exceptionAudit/tareWeightApply", Common<TareWeightApply>(apply, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJsno);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 皮重异常查询是否审批
        /// </summary>
        /// <param name="tareId"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> TareWeighExceptionQuery(string tareId,string userid)
        {
            try
            {
                TareWeightExQuery tareQuery = new TareWeightExQuery();
                tareQuery.id = tareId;
                string strJsno = httpUtil.post(url + "/api/exceptionAudit/tareWeightQuery", Common<TareWeightExQuery>(tareQuery, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJsno);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获得小票号
        /// </summary>
        /// <param name="item"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<SmallTicket> GetQueueTicketApiJson(QueueTicket item, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/doorSystem/newQueueNumber", Common<QueueTicket>(item, userid));
                Result<SmallTicket> res = JsonConvert.DeserializeObject<Result<SmallTicket>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 查询车辆类别和IC卡信息
        /// </summary>
        /// <param name="item"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<ReICInfo> getByVehicleApiJson(RequestVehicle item, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/vehicle/getByVehicle", Common<RequestVehicle>(item, userid));
                Result<ReICInfo> res = JsonConvert.DeserializeObject<Result<ReICInfo>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// 上传入场门禁（新）（临时车/固定车）  目前只能入厂，不能出厂
        /// </summary>
        /// <param name="item"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> PostGateRecordNewApiJson(GateData item, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/doorSystem/uploadInfoAR", Common<GateData>(item, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }          
        }

        /// <summary>
        /// 补包申请
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> FillPackpageApply(FillPackpageRequest obj,string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/piSalesArrive/makeUpApplication", Common<FillPackpageRequest>(obj, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }  
        }

        /// <summary>
        /// 无需补包申请
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> UnFillPackpageApply(string notice,string userid)
        {
            try
            {
                UnFillPackpageRequest obj = new UnFillPackpageRequest();
                obj.noticeNo = notice;
                string strJson = httpUtil.post(url + "/api/piSalesArrive/noNeedMakeUp", Common<UnFillPackpageRequest>(obj, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }  
        }

        /// <summary>
        /// 空车出厂
        /// </summary>
        /// <param name="lorry"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> EmptyLorryLeaving(string lorry,string userid)
        {
            try
            {
                EmptyCarLeavingApply obj = new EmptyCarLeavingApply();
                obj.vehicleNo = lorry;
                string strJson = httpUtil.post(url + "/api/poundNote/emptyCarLeavingFactory", Common<EmptyCarLeavingApply>(obj, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            } 
        }
        /// <summary>
        /// 查询过磅单详情
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <param name="billtype"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<PoundTicketDetail> QueryPoundTicketDetail(string noticeNo, string billtype, string userid)
        {
            try
            {
                PoundTicketDetailReq pdr = new PoundTicketDetailReq();
                pdr.noticeNo = noticeNo;
                pdr.billtype = billtype;

                string strJson = httpUtil.post(url + "/api/piSalesArrive/newDetail", Common<PoundTicketDetailReq>(pdr, userid));
                Result<PoundTicketDetail> res = JsonConvert.DeserializeObject<Result<PoundTicketDetail>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
           

        }
        /// <summary>
        /// 装车完成
        /// </summary>
        /// <param name="item">RFID、车牌号</param>
        /// <param name="userid">用户ID</param>
        /// <returns></returns>
        public Result<string> ConfirmationOfShipmentApiJson(ConShipment item, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/piSalesArrive/confirmationOfShipment", Common<ConShipment>(item, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 监控中心获取销售散装物料
        /// </summary>
        /// <param name="item">RFID、车牌号</param>
        /// <param name="userid">用户ID</param>
        /// <returns></returns>
        public List<MaterialInfo> getMaterielArray(string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/dc/materiel/getMaterielArray", Common<object>(null, userid));
                Result<object> res = JsonConvert.DeserializeObject<Result<object>>(strJson);
               List<MaterialInfo> res1 = JsonConvert.DeserializeObject<Result<List<MaterialInfo>>>(strJson).returnData.ToList<MaterialInfo>();
                return res1;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 补包袋数
        /// </summary>
        /// <param name="item"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Result<string> SelectBundleNumberApiJson(NeedMakeUpNum item, string userid)
        {
            try
            {
                string strJson = httpUtil.post(url + "/api/piSalesArrive/selectBundleNumber", Common<NeedMakeUpNum>(item, userid));
                Result<string> res = JsonConvert.DeserializeObject<Result<string>>(strJson);
                return res;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 袋装排队接口
        /// </summary>
        /// <returns>QueryWaiting</returns>
        public Result<QueryWaiting[]> GetBagsQueuingAPIJson(RFIDTag tag, string userid)
        {
            try
            {
                string strjson = httpUtil.post(url + "/api/doorSystem/queryWaiting", Common<RFIDTag>(tag, userid));
                Result<QueryWaiting[]> res = JsonConvert.DeserializeObject<Result<QueryWaiting[]>>(strjson);
                return res;
            }
            catch (WebException e)
            {
                throw e;
            }
        }
    }
}
