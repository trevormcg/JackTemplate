using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication3;

namespace ConsoleApplication3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Fund fund = new Fund() {FundType = FundType.MasterFeeder};
         //cimm
            FundBuilder builder = BuilderFactory.GetBuilder(fund);
            builder.Build(fund);
        }
    }

    public class Fund
    {

        public FundType FundType { get; set; }
    }

    public enum FundType
    {
        BDC,
        MasterFeeder
    }

    public static class BuilderFactory
    {

        public static FundBuilder GetBuilder(Fund fund)
        {
            if (fund.FundType == FundType.BDC)
                return new BDCBuilder();
            else if (fund.FundType == FundType.MasterFeeder)
            {
                return new MasterFeederBuilder();
            }

            throw new NotImplementedException();
        }
    }

    public abstract class FundBuilder
    {
        public abstract void Build(Fund fund);

    }

    public class BDCBuilder : FundBuilder
    {
        public override void Build(Fund fund)
        {
            throw new NotImplementedException();
        }
    }

    public class MasterFeederBuilder : FundBuilder
    {
        public override void Build(Fund fund)
        {
            throw new NotImplementedException();
        }
    }

}