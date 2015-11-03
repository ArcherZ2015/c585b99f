﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;

using CarManage.Configuration;
using ClassLibrary.ExceptionHandling;
using ClassLibrary.Common;

namespace CarManage.DataAccess.MySql
{
    public class Test : DataAccessBase
    {
        /// <summary>
        /// 实体名称和数据库表名可以不一样，插入机制是通过实体属性名和数据库表名字段名实现的
        /// </summary>
        public void Insert()
        {
            QuestionInfo questionInfo = new QuestionInfo();

            questionInfo.Title = "Dapper单表实体插入";
            questionInfo.Content = "简单测试";
            questionInfo.Rank = 1;
            questionInfo.Rate = 2.88888m;
            questionInfo.Remark = "无";
            questionInfo.Description = "desc";
            questionInfo.CreateDate = DateTime.Now;
            questionInfo.Valid = true;
            //DapperExtensions.DapperExtensions.Configure(typeof(CustomTableMapper<>), new List<System.Reflection.Assembly>(), new DapperExtensions.Sql.MySqlDialect());

            //DapperExtensions.DapperExtensions.DefaultMapper = typeof(CustomTableMapper<>);

//            string commandText = @"INSERT INTO Question(Title,Content,Rank,Rate,Remark,Description,CreateDate,Valid)
//                                        VALUES(@Title,@Content,@Rank,@Rate,@Remark,@Description,@CreateDate,@Valid)";

            using (IDbConnection connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString))
            {
                //connection.Open();
                //connection.Execute(commandText, questionInfo);
                //int rsult = base.Execute(commandText, connection, param: questionInfo);
                //var info = base.Get<QuestionInfo>(29, connection);

                //commandText = "select * from Question where id=@id and Title like concat('%',@Title,'%')";
                //QuestionInfo q = new QuestionInfo();
                //q.Id = 8;
                //q.Title = "a";
                //var reuslt = base.Query<QuestionInfo>(commandText, connection);
                //var r = base.Load<QuestionInfo>("select * from Question where Id=@Id", connection, param: new { Id = 1 });
                //var list = connection.Query<QuestionInfo>(commandText, q);

                StringBuilder filter = new StringBuilder();

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM Question {0}", filterText);

                int count = base.ExecuteObject<int>(commandText, connection);

                //if (queryInfo.TotalCount.Equals(0))
                //    return brandList;
            }
            //try
            //{
            //    IDbConnection connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
            //    base.Insert<QuestionInfo>(questionInfo, connection);
            //}
            //catch (Exception ex)
            //{
            //    DataAccessExceptionHandler.HandlerException("新增信息失败！", ex);
            //}
        }
    }
    

    public class QuestionInfo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int? Rank { get; set; }

        public decimal? Rate { get; set; }

        public string Remark { get; set; }

        public string Description { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool Valid { get; set; }


        public List<AnswerInfo> Answers { get; set; }
    }

    public class AnswerInfo
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public string Commet { get; set; }

        public decimal Score { get; set; }
    }

    //public class CustomTableMapper<T> : DapperExtensions.Mapper.AutoClassMapper<T> where T : class
    //{
    //    public override void Table(string tableName)
    //    {
    //        if (tableName.EndsWith("Info"))
    //        {
    //            TableName = tableName.Substring(0, tableName.Length - 4);
    //        }
    //        base.Table(TableName);
    //    }
    //}
}
