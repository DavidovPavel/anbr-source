namespace www.Models.Ex.Feed
{
    public class HeadProperty : BaseProperty
    {
        public string displayName { get; set; }
        public bool isVisible { get; set; }

        /// <summary>
        /// ������� ���� ��� ��� ����������
        /// </summary>
        public bool isCalc { get; set; }

        /// <summary>
        /// ���������� ������������� �������� �������� ��������
        /// </summary>
        public bool htmlEncoded { get; set; }

        /// <summary>
        /// ������ ������������ �������� href ��� c�������
        /// </summary>
        public string template { get; set; }
    }
}