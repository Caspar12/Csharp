/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define.Entities;
namespace Zh.DAL.Define.Entities
{
	#region T_Guest

	/// <summary>
    /// 
	/// T_Guest object for mapped table 'T_Guest'.
	/// </summary>
	public partial class T_Guest
	{
		
		#region Constructors
        
		public T_Guest() { }        
        
		public T_Guest( int guestIndex, string shopID, string guestNumber, DateTime guestRegTime, string guestName, string guestSex, string guestHandTel, string guestEmail, string guestQQ, string guestAddr, string guestDeciders, string carNumberID, string carTypeBig, string carType, string gears, string carColor, string guestFrom, string guestState, string guestLevel, string followWay, string guestFollow, string guestPSW, string guestSpell, string guestClass, int? guestHot, string guestLv, string cardID, string guestIdentID, string guestDriveID, int? memberLv, DateTime? memberEnd, decimal? guestMoney, decimal? guestIntegral, DateTime? lastLoginTime, string guestCode, string guestFax, DateTime? guestBirthday, string gMarriage, DateTime? gBegWorkTime, string gRace, string gcokuser, string gcokmodu, DateTime? gCokDate, string gContact, string gConSex, string gConHandTel, string guestEnjoy, string gCity, string gArea, string gIntroducer, string guestLoveServe, string guestOrigin, string carFrom, string carNumberSpell, string carFrameID, string carEngineID, DateTime? carBuyDate, DateTime? carUpBrandDate, string carRunID, DateTime? carYearDate, DateTime? carInsurerEndDate, string carLastInsurer, decimal? carRunMile, decimal? carFirstRunMile, decimal? carTendMile, decimal? carAverKilo, string carBuyPlace, string carUesArea, string carMethod, string carInWay, string carUseProperty, string guestRemark, string carRemark, string otherUID, string guestProperties, string carNumber, string guestDescribe, DateTime? insureDate, string guestPhoneNumber, DateTime? askforDate, string auditor, string auditMemberLevel, DateTime? auditTime, string followState, byte[] stamp, bool isDelete, DateTime? validDateTime )
		{
			this.GuestIndex = guestIndex;
			this.ShopID = shopID;
			this.GuestNumber = guestNumber;
			this.GuestRegTime = guestRegTime;
			this.GuestName = guestName;
			this.GuestSex = guestSex;
			this.GuestHandTel = guestHandTel;
			this.GuestEmail = guestEmail;
			this.GuestQQ = guestQQ;
			this.GuestAddr = guestAddr;
			this.GuestDeciders = guestDeciders;
			this.CarNumberID = carNumberID;
			this.CarTypeBig = carTypeBig;
			this.CarType = carType;
			this.Gears = gears;
			this.CarColor = carColor;
			this.GuestFrom = guestFrom;
			this.GuestState = guestState;
			this.GuestLevel = guestLevel;
			this.FollowWay = followWay;
			this.GuestFollow = guestFollow;
			this.GuestPSW = guestPSW;
			this.GuestSpell = guestSpell;
			this.GuestClass = guestClass;
			this.GuestHot = guestHot;
			this.GuestLv = guestLv;
			this.CardID = cardID;
			this.GuestIdentID = guestIdentID;
			this.GuestDriveID = guestDriveID;
			this.MemberLv = memberLv;
			this.MemberEnd = memberEnd;
			this.GuestMoney = guestMoney;
			this.GuestIntegral = guestIntegral;
			this.LastLoginTime = lastLoginTime;
			this.GuestCode = guestCode;
			this.GuestFax = guestFax;
			this.GuestBirthday = guestBirthday;
			this.GMarriage = gMarriage;
			this.GBegWorkTime = gBegWorkTime;
			this.GRace = gRace;
			this.Gcokuser = gcokuser;
			this.Gcokmodu = gcokmodu;
			this.GCokDate = gCokDate;
			this.GContact = gContact;
			this.GConSex = gConSex;
			this.GConHandTel = gConHandTel;
			this.GuestEnjoy = guestEnjoy;
			this.GCity = gCity;
			this.GArea = gArea;
			this.GIntroducer = gIntroducer;
			this.GuestLoveServe = guestLoveServe;
			this.GuestOrigin = guestOrigin;
			this.CarFrom = carFrom;
			this.CarNumberSpell = carNumberSpell;
			this.CarFrameID = carFrameID;
			this.CarEngineID = carEngineID;
			this.CarBuyDate = carBuyDate;
			this.CarUpBrandDate = carUpBrandDate;
			this.CarRunID = carRunID;
			this.CarYearDate = carYearDate;
			this.CarInsurerEndDate = carInsurerEndDate;
			this.CarLastInsurer = carLastInsurer;
			this.CarRunMile = carRunMile;
			this.CarFirstRunMile = carFirstRunMile;
			this.CarTendMile = carTendMile;
			this.CarAverKilo = carAverKilo;
			this.CarBuyPlace = carBuyPlace;
			this.CarUesArea = carUesArea;
			this.CarMethod = carMethod;
			this.CarInWay = carInWay;
			this.CarUseProperty = carUseProperty;
			this.GuestRemark = guestRemark;
			this.CarRemark = carRemark;
			this.OtherUID = otherUID;
			this.GuestProperties = guestProperties;
			this.CarNumber = carNumber;
			this.GuestDescribe = guestDescribe;
			this.InsureDate = insureDate;
			this.GuestPhoneNumber = guestPhoneNumber;
			this.AskforDate = askforDate;
			this.Auditor = auditor;
			this.AuditMemberLevel = auditMemberLevel;
			this.AuditTime = auditTime;
			this.FollowState = followState;
			this.Stamp = stamp;
			this.IsDelete = isDelete;
			this.ValidDateTime = validDateTime;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 客户表ID索引,客户表字段太多,在表示层可不需要添加这么多资料,只要能先建立档案即可.
        /// </summary>
		public virtual int GuestIndex { get; set; }
        /// <summary>
        /// 店号
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 客户编号,自动生成(2012-06-11新增)
        /// </summary>
		public virtual string GuestNumber { get; set; }
        /// <summary>
        /// 注册时间,登记时间
        /// </summary>
		public virtual DateTime GuestRegTime { get; set; }
        /// <summary>
        /// 客户名称,注册客户最少需要提供邮件或手机号
        /// </summary>
		public virtual string GuestName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
		public virtual string GuestSex { get; set; }
        /// <summary>
        /// 手机号,很重要,可存储2-3个电话用,分割
        /// </summary>
		public virtual string GuestHandTel { get; set; }
        /// <summary>
        /// 电子邮件,很重要,可用作ID
        /// </summary>
		public virtual string GuestEmail { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
		public virtual string GuestQQ { get; set; }
        /// <summary>
        /// 通讯地址
        /// </summary>
		public virtual string GuestAddr { get; set; }
        /// <summary>
        /// 决定人
        /// </summary>
		public virtual string GuestDeciders { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
		public virtual string CarNumberID { get; set; }
        /// <summary>
        /// 车型,大车型,直接存名字即可
        /// </summary>
		public virtual string CarTypeBig { get; set; }
        /// <summary>
        /// 细车型,直接存名字即可
        /// </summary>
		public virtual string CarType { get; set; }
        /// <summary>
        /// 排档(2012-12-26新增)
        /// </summary>
		public virtual string Gears { get; set; }
        /// <summary>
        /// 车身颜色
        /// </summary>
		public virtual string CarColor { get; set; }
        /// <summary>
        /// 客户来源，导入或新增(2012-06-11新增)
        /// </summary>
		public virtual string GuestFrom { get; set; }
        /// <summary>
        /// 客户状态,正常、删除、战败、订车(潜客未成功)潜客(1.录入 2.审核 3.跟进中  4.成交  5.失败结案)等标志
        /// </summary>
		public virtual string GuestState { get; set; }
        /// <summary>
        /// 会员级别，网站上注册的为普通会员(2012-06-11新增)
        /// </summary>
		public virtual string GuestLevel { get; set; }
        /// <summary>
        /// 跟进方式
        /// </summary>
		public virtual string FollowWay { get; set; }
        /// <summary>
        /// 跟进内容(2012-06-12新增)
        /// </summary>
		public virtual string GuestFollow { get; set; }
        /// <summary>
        /// 客户登录密码
        /// </summary>
		public virtual string GuestPSW { get; set; }
        /// <summary>
        /// 客户名称拼音码
        /// </summary>
		public virtual string GuestSpell { get; set; }
        /// <summary>
        /// 客户类别,自定义设置：存量客户、潜在客户、逾期客户、流失客户、恶性客户
        /// </summary>
		public virtual string GuestClass { get; set; }
        /// <summary>
        /// 潜客热度,可在枚举中定义名称来更直观的显示，如分为H.A.B等,主要用来判断客户的价值
        /// </summary>
		public virtual int? GuestHot { get; set; }
        /// <summary>
        /// 客户等级,存量客户的热度,根据需求或情况,表示对待等级,和会员级别不一样，此处主要用来判断客户的价值
        /// </summary>
		public virtual string GuestLv { get; set; }
        /// <summary>
        /// 卡号默认与客户ID相同，如果是ID卡，则取ID卡内数据,ID卡号仅10位
        /// </summary>
		public virtual string CardID { get; set; }
        /// <summary>
        /// 身份证号,能采集到最好
        /// </summary>
		public virtual string GuestIdentID { get; set; }
        /// <summary>
        /// 驾驶证号,能采集到最好
        /// </summary>
		public virtual string GuestDriveID { get; set; }
        /// <summary>
        /// 会员等级
        /// </summary>
		public virtual int? MemberLv { get; set; }
        /// <summary>
        /// 会员有效期,会员到期时间
        /// </summary>
		public virtual DateTime? MemberEnd { get; set; }
        /// <summary>
        /// 会员余额
        /// </summary>
		public virtual decimal? GuestMoney { get; set; }
        /// <summary>
        /// 会员积分
        /// </summary>
		public virtual decimal? GuestIntegral { get; set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
		public virtual DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
		public virtual string GuestCode { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
		public virtual string GuestFax { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
		public virtual DateTime? GuestBirthday { get; set; }
        /// <summary>
        /// 婚姻状况
        /// </summary>
		public virtual string GMarriage { get; set; }
        /// <summary>
        /// 分配时间
        /// </summary>
		public virtual DateTime? GBegWorkTime { get; set; }
        /// <summary>
        /// 驾驶证初登日期
        /// </summary>
		public virtual string GRace { get; set; }
        /// <summary>
        /// 资料所有者
        /// </summary>
		public virtual string Gcokuser { get; set; }
        /// <summary>
        /// 资料最后修改者
        /// </summary>
		public virtual string Gcokmodu { get; set; }
        /// <summary>
        /// 最后修改日期
        /// </summary>
		public virtual DateTime? GCokDate { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
		public virtual string GContact { get; set; }
        /// <summary>
        /// 联系人性别
        /// </summary>
		public virtual string GConSex { get; set; }
        /// <summary>
        /// 联系人电话,可存储2-3个电话用,分割
        /// </summary>
		public virtual string GConHandTel { get; set; }
        /// <summary>
        /// 兴趣爱好
        /// </summary>
		public virtual string GuestEnjoy { get; set; }
        /// <summary>
        /// 所在城市
        /// </summary>
		public virtual string GCity { get; set; }
        /// <summary>
        /// 所在区域
        /// </summary>
		public virtual string GArea { get; set; }
        /// <summary>
        /// 介绍人
        /// </summary>
		public virtual string GIntroducer { get; set; }
        /// <summary>
        /// 喜好的服务
        /// </summary>
		public virtual string GuestLoveServe { get; set; }
        /// <summary>
        /// 潜客来源，展厅客户、电销客户,用于销售潜在客户的来源
        /// </summary>
		public virtual string GuestOrigin { get; set; }
        /// <summary>
        /// 存量来源,1、售车，2、配件，3、维修，4、保险，5、理赔，6、其他,用于服务的存量客户的来源
        /// </summary>
		public virtual string CarFrom { get; set; }
        /// <summary>
        /// 车牌拼音码
        /// </summary>
		public virtual string CarNumberSpell { get; set; }
        /// <summary>
        /// 车架号,或底盘号
        /// </summary>
		public virtual string CarFrameID { get; set; }
        /// <summary>
        /// 发动机号
        /// </summary>
		public virtual string CarEngineID { get; set; }
        /// <summary>
        /// 购车日期,购车日期或登记日期(新车的订单创建日期)
        /// </summary>
		public virtual DateTime? CarBuyDate { get; set; }
        /// <summary>
        /// 车辆上牌时间
        /// </summary>
		public virtual DateTime? CarUpBrandDate { get; set; }
        /// <summary>
        /// 行驶证号
        /// </summary>
		public virtual string CarRunID { get; set; }
        /// <summary>
        /// 年审日期
        /// </summary>
		public virtual DateTime? CarYearDate { get; set; }
        /// <summary>
        /// 保险到期日期
        /// </summary>
		public virtual DateTime? CarInsurerEndDate { get; set; }
        /// <summary>
        /// 最后一次投保的保险公司
        /// </summary>
		public virtual string CarLastInsurer { get; set; }
        /// <summary>
        /// 行驶里程
        /// </summary>
		public virtual decimal? CarRunMile { get; set; }
        /// <summary>
        /// 首次行驶里程
        /// </summary>
		public virtual decimal? CarFirstRunMile { get; set; }
        /// <summary>
        /// 保养里程
        /// </summary>
		public virtual decimal? CarTendMile { get; set; }
        /// <summary>
        /// 平均公里数
        /// </summary>
		public virtual decimal? CarAverKilo { get; set; }
        /// <summary>
        /// 购车地点
        /// </summary>
		public virtual string CarBuyPlace { get; set; }
        /// <summary>
        /// 主要用车地,1.本地  2.周边  3.外地
        /// </summary>
		public virtual string CarUesArea { get; set; }
        /// <summary>
        /// 主要用途,1.代步  2.商用载人  3.客货两用
        /// </summary>
		public virtual string CarMethod { get; set; }
        /// <summary>
        /// 进厂习惯,1.频繁 2.正常 3.游离
        /// </summary>
		public virtual string CarInWay { get; set; }
        /// <summary>
        /// 使用性质,1.公司车  2.个人   3.出租车  4.其他
        /// </summary>
		public virtual string CarUseProperty { get; set; }
        /// <summary>
        /// 客户备注
        /// </summary>
		public virtual string GuestRemark { get; set; }
        /// <summary>
        /// 车辆备注
        /// </summary>
		public virtual string CarRemark { get; set; }
        /// <summary>
        /// 其他的ID，可用"，"分割
        /// </summary>
		public virtual string OtherUID { get; set; }
        /// <summary>
        /// 会员性质(2012-06-11新增)
        /// </summary>
		public virtual string GuestProperties { get; set; }
        /// <summary>
        /// 汽车编号,自动生成(2012-06-11新增)
        /// </summary>
		public virtual string CarNumber { get; set; }
        /// <summary>
        /// 客户描述(2012-06-12新增)
        /// </summary>
		public virtual string GuestDescribe { get; set; }
        /// <summary>
        /// 投保日期(2012-06-12新增)
        /// </summary>
		public virtual DateTime? InsureDate { get; set; }
        /// <summary>
        /// 电话号码(2012-06-12新增)
        /// </summary>
		public virtual string GuestPhoneNumber { get; set; }
        /// <summary>
        /// 申请日期(2012-06-12新增)
        /// </summary>
		public virtual DateTime? AskforDate { get; set; }
        /// <summary>
        /// 审核人(2012-06-12新增)
        /// </summary>
		public virtual string Auditor { get; set; }
        /// <summary>
        /// 审核会员级别(2012-06-12新增)
        /// </summary>
		public virtual string AuditMemberLevel { get; set; }
        /// <summary>
        /// 审核时间(2012-06-12新增)
        /// </summary>
		public virtual DateTime? AuditTime { get; set; }
        /// <summary>
        /// 跟进后状态,不成功、白金初级、白金中级、白金高级、错误单
        /// </summary>
		public virtual string FollowState { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
		public virtual bool IsDelete { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? ValidDateTime { get; set; }
        
        
        /// <summary>
        /// 活动抽奖历史表
        /// </summary>
        public virtual IList<Activity_History> Activity_History{get;set;}
        /// <summary>
        /// 活动中奖人员表
        /// </summary>
        public virtual IList<Activity_UserPrize> Activity_UserPrize{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<T_GuestContact> T_GuestContact{get;set;}
        /// <summary>
        /// 维修消费记录
        /// </summary>
        public virtual IList<Repair_Orders> Repair_Orders{get;set;}


		#endregion
	 
	}
	#endregion
}
 