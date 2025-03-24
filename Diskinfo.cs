using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仿windows10电脑
{
    class Diskinfo
    {
        private int did;
        private string diskname;
        private double sum;
        private double nullkj;
        private string Type;
        private static List<Diskinfo> partitions = new List<Diskinfo>();
        public int Did { get => did; set => did = value; }
        public string Diskname { get => diskname; set => diskname = value; }
        public double Sum { get => sum; set => sum = value; }
        public double Nullkj { get => nullkj; set => nullkj = value; }
        public string Type1 { get => Type; set => Type = value; }
        public static void AddPartition(Diskinfo partition)
        {
            partitions.Add(partition);
        }

        // 检查是否有分区
        public static bool HasPartitions()
        {
            return partitions.Count > 0;
        }

        // 获取所有分区
        public static List<Diskinfo> GetPartitions()
        {
            return partitions;
        }
    }
}

