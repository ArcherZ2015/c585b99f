﻿#region CopyRight
// -----------------------------------------------------------------------------------
// 版权声明： 
// 使用声明： 任何组织和个人未经许可不得擅自复制或更改其内容
// 软件版本： 1.0
// 公司地址： 
// 公司电话： ***
// -----------------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;

using CarManage.Model;

namespace CarManage.Model.Common
{
    ///<summary>
    ///<summary>基础代码信息对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-14</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    public class CodeBookInfo : BaseModel
    {
        #region 基础代码分类

        /// <summary>
        /// 客户称呼代码类型编号
        /// </summary>
        public static readonly string AliasCodeType = "";

        /// <summary>
        /// 喜欢的销售活动代码类型编号
        /// </summary>
        public static readonly string PreferSaleCodeType = "";

        /// <summary>
        /// 喜欢的售后活动代码类型编号
        /// </summary>
        public static readonly string PreferSupportCodeType = "";

        /// <summary>
        /// 喜欢的饮品代码类型编号
        /// </summary>
        public static readonly string PreferDrinkCodeType = "";

        /// <summary>
        /// 销售类型代码类型编号
        /// </summary>
        public static readonly string SaleTypeCodeType = "";

        /// <summary>
        /// 保养周期代码类型编号
        /// </summary>
        public static readonly string MaintenancePeriodCodeType = "";

        /// <summary>
        /// 保养间隔里程代码类型编号
        /// </summary>
        public static readonly string MaintenanceMileageCodeType = "";

        /// <summary>
        /// 保养项目代码类型编号
        /// </summary>
        public static readonly string MaintenanceItemCodeType = "";

        /// <summary>
        /// 保险项目代码类型编号
        /// </summary>
        public static readonly string InsuranceItemCodeType = "";

        /// <summary>
        /// 保险公司代码类型编码
        /// </summary>
        public static readonly string InsuranceCompanyCodeType = "";

        #endregion

        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public CodeBookInfo()
        {

        }

        #endregion

        #region 基础属性

        ///<summary>
        ///主键
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        ///代码类型
        ///</summary>
        public string Type { get; set; }

        ///<summary>
        ///代码
        ///</summary>
        public string Code { get; set; }

        ///<summary>
        ///名称
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        ///备注
        ///</summary>
        public string Remark { get; set; }

        ///<summary>
        ///排序序号
        ///</summary>
        public int SortOrder { get; set; }

        ///<summary>
        ///是否有效
        ///</summary>
        public bool Valid { get; set; }


        #endregion

        #region 扩展属性

        #endregion
    }
}