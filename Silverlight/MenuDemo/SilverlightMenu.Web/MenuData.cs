using System.Collections.Generic;

namespace SilverlightMenu.Web
{
    public class MenuData
    {
        public int Id { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// �˵���Ŀ
        /// </summary>
        public List<MenuItem> MenuItems { get; set; }
        /// <summary>
        /// �Ƿ�Ϊ�ö��˵�
        /// </summary>
        public bool IsTop { get; set; }
    }

    public class MenuItem
    {
        public int Id { get; set; }
        /// <summary>
        /// �˵�����
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// �˵�����
        /// </summary>
        public string Url { get; set; }
    }
}