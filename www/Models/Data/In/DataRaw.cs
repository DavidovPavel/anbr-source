using System;
using System.Data;
using www.Models.Data.Common;
using www.Models.Data.Logic;

namespace www.Models.Data.In
{
    /// <summary>
    /// ������������ ���������� ����������� SA �������
    /// </summary>
    public class DataRaw
    {
        /// <summary>
        /// ������
        /// </summary>
        public DataTable data { get; set; }
        /// <summary>
        /// ����� ���������� �������
        /// </summary>
        public int TotalRecordCount { get; set; }
        /// <summary>
        /// ������ ��������
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// ������� ��������
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// �������� ��������� ������ ��� ���������������� ���� ������������
        /// </summary>
        /// <param name="vType"></param>
        /// <returns></returns>
        public ParserDataRaw ParserGet(VisualizatonType vType)
        {
            return ParserDataRaw.GetInstance(data.DataSet.Tables[0], vType);
        }
    }
}
