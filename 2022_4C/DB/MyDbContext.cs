//using _2022_4C.DB.BA;
//using _2022_4C.DB.EE;
//using _2022_4C.DB.FI;
//using _2022_4C.DB.IN;
//using _2022_4C.DB.IR;
//using _2022_4C.DB.LO;
//using _2022_4C.DB.OF;
//using _2022_4C.DB.PA;
//using _2022_4C.DB.PU;
//using _2022_4C.DB.TR;
//using _2022_4C.DB.VE;
//using _2022_4C.DB.VO;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2022_4C.DB
//{
//    /// <summary>
//    /// 外部调用，操作数据库接口
//    /// </summary>
//    public class MyDbContext : DbContext
//    {
//        #region 基础管理模块
//        public DbSet<data_BAAdmin> BAAdmin { get; set; }
//        public DbSet<data_BAEmployee> BAEmployee { get; set; }
//        public DbSet<data_BAExpenseAccount> BAExpenseAccount { get; set; }
//        public DbSet<data_BALeave> BALeaves { get; set; }
//        public DbSet<data_BAAttendanceSheet> BAAttendanceSheet { get; set; }
//        #endregion

//        #region 车辆进出场管理模块
//        public DbSet<data_EEEnterArena> EEEnterArena { get; set; }
//        public DbSet<data_EEExitArena> EEExitArena { get; set; }
//        #endregion

//        #region 车辆管理模块
//        public DbSet<date_VETemporaryVehicle> VETemporaryVehicle { get; set; }
//        public DbSet<data_VEFixedVehicle> VEFixedVehicle { get; set; }
//        public DbSet<data_VEUnlicensedVehicle> VEUnlicensedVehicle { get; set; }
//        public DbSet<data_VESpecialVehicle> VESpecialVehicle { get; set; }
//        #endregion

//        #region 闲时出租模块
//        public DbSet<data_IRRentOut> IRRentOut { get; set; }
//        public DbSet<data_IRState> IRState { get; set; }
//        #endregion

//        #region 车主管理模块
//        public DbSet<data_VOFixedVehicle> VOFixedVehicle { get; set; }
//        public DbSet<data_VOUnlicensedVehicle> VOUnlicensedVehicle { get; set; }
//        #endregion

//        #region 停车场管理模块
//        public DbSet<data_PAPark> PAPark { get; set; }
//        public DbSet<data_PAParkingArea> PAParkingArea { get; set; }
//        public DbSet<data_PAParkingSpot> PAParkingSpot { get; set; }
//        #endregion

//        #region 日志管理模块
//        public DbSet<data_LOIdleRent> LOIdleRent { get; set; }
//        public DbSet<data_LOParkingArea> LOParkingArea { get; set; }
//        public DbSet<data_LOPark> LOPark { get; set; }
//        public DbSet<data_LOEnterExit> LOEnterExit { get; set; }
//        #endregion

//        #region 订单管理模块
//        public DbSet<data_OFTemporaryVehicle> OFTemporaryVehicle { get; set; }
//        public DbSet<data_OFFixedVehicle> OFFixedVehicle { get; set; }
//        public DbSet<data_OFIdleRent> OFIdleRent { get; set; }
//        public DbSet<data_OFUnlicensedVehicle> OFUnlicensedVehicle { get; set; }
//        public DbSet<data_OFSpecielVehicle> OFSpecielVehicle { get; set; }
//        #endregion

//        #region 财务管理模块
//        public DbSet<data_FIRates> FIRates { get; set; }
//        public DbSet<data_FIVehicleCharge> FIVehicleCharge { get; set; }
//        public DbSet<data_FIDisbursement> FIDisbursement { get; set; }
//        public DbSet<data_FIReturnRent> FIReturnRent { get; set; }
//        public DbSet<data_FIFiance> FIFiance { get; set; }
//        #endregion

//        #region 采购管理模块
//        public DbSet<data_PUEquipmentPurchasing> PUEquipmentPurchasing { get; set; }
//        public DbSet<data_PUEquipment> PUEquipment { get; set; }
//        public DbSet<data_PUEngineeringConstruction> PUEngineeringConstruction { get; set; }
//        public DbSet<data_PUConstructionItem> PUConstructionItem { get; set; }
//        #endregion

//        #region 事故管理模块
//        public DbSet<data_TRVehicleTraffic> TRVehicleTraffic { get; set; }
//        public DbSet<data_TRMalfunction> TRMalfunction { get; set; }
//        #endregion

//        #region 内置系统信息模块
//        public DbSet<data_INViolationVehicle> INViolationVehicle { get; set; }
//        public DbSet<data_VehicleBlacklist> VehicleBlacklist { get; set; }
//        public DbSet<data_INOwnerBlacklist> INOwnerBlacklist { get; set; }
//        #endregion

//        // 连接到数据库
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            // 连接信息
//            string sql = @"Server=localhost; Port=3306; Database=db_tcc; User=root; Password=740826010226; CharSet=utf8; Allow User Variables=true;";
//            optionsBuilder.UseMySQL(sql);
//        }

//        // 数据模式回调
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//            // modelBuilder.Entity<datal>().HasNoKey();
//        }
//    }
//}
