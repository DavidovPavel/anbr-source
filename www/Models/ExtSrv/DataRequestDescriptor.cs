using System;
using System.Collections.Generic;

namespace www.Models.ExtSrv
{
    /// <summary>
    /// ��������� �������� ������, ����������� ��� ���������� ������� ������� SA
    /// </summary>
    public class DataRequestDescriptor
    {
        /// <summary>
        /// ������������� �������
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// ����� ������� ��������
        /// </summary>
        public int page { get; set; }
        public int pagesize { get; set; }

        /// <summary>
        /// ���� ������������� ���������� ��-���������
        /// ����������� ������ ��� ������ � ��������� (������ ���� ������������� ��������� �������)
        /// </summary>
        public bool? useDefParams { get; set; }

        /// <summary>
        /// ���������
        /// </summary>
        public List<QueryParameter> pars { get; set; }

        /// <summary>
        /// ����� ������ ������, ���������� �� ����� (�� ������ ����� �� �������)
        /// </summary>
        public string ts { get; set; }

        /// <summary>
        /// ������������ �������� ������� ��� ������������� ���������� ������
        /// </summary>
        public string ruleCode { get; set; }

        public WidgetDescriptor widget { get; set; }
    }

    /// <summary>
    /// ��������� ������, � ����������� ������
    /// </summary>
    public class WidgetDescriptor
    {
        public string name { get; set; }
        public string type { get; set; }
        public Guid uid { get; set; }
        public string Visualization { get; set; }
    }
}