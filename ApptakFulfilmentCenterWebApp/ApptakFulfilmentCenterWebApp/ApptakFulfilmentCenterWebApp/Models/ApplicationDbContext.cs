using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AbtSkuCode> AbtSkuCodes { get; set; }

    public virtual DbSet<AddArea> AddAreas { get; set; }

    public virtual DbSet<AddCity> AddCities { get; set; }

    public virtual DbSet<AddCountry> AddCountries { get; set; }

    public virtual DbSet<AddProvince> AddProvinces { get; set; }

    public virtual DbSet<AglAuditApi> AglAuditApis { get; set; }

    public virtual DbSet<AglOrder> AglOrders { get; set; }

    public virtual DbSet<AglOrderCity> AglOrderCities { get; set; }

    public virtual DbSet<AglOrderConsignment> AglOrderConsignments { get; set; }

    public virtual DbSet<AglOrderLoadsheet> AglOrderLoadsheets { get; set; }

    public virtual DbSet<AglOrderStatus> AglOrderStatuses { get; set; }

    public virtual DbSet<AglReturnsReasonCode> AglReturnsReasonCodes { get; set; }

    public virtual DbSet<AglSkuCode> AglSkuCodes { get; set; }

    public virtual DbSet<AglSkuCodeBk> AglSkuCodeBks { get; set; }

    public virtual DbSet<ApiEndpoint> ApiEndpoints { get; set; }

    public virtual DbSet<ApptakUserRole> ApptakUserRoles { get; set; }

    public virtual DbSet<AssignCustomersUser> AssignCustomersUsers { get; set; }

    public virtual DbSet<B2bAuditApi> B2bAuditApis { get; set; }

    public virtual DbSet<B2bEcommerceSale> B2bEcommerceSales { get; set; }

    public virtual DbSet<BkChildItem020723> BkChildItem020723s { get; set; }

    public virtual DbSet<BkMasterItem020723> BkMasterItem020723s { get; set; }

    public virtual DbSet<BkOrderDetail> BkOrderDetails { get; set; }

    public virtual DbSet<BkSghOrder> BkSghOrders { get; set; }

    public virtual DbSet<BkSghOrderConsignment> BkSghOrderConsignments { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CellOrder> CellOrders { get; set; }

    public virtual DbSet<ChildItem> ChildItems { get; set; }

    public virtual DbSet<ChildItem1> ChildItems1 { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<ContactU> ContactUs { get; set; }

    public virtual DbSet<CorporateAddress> CorporateAddresses { get; set; }

    public virtual DbSet<CourierAccountDetail> CourierAccountDetails { get; set; }

    public virtual DbSet<CourierBookingDetail> CourierBookingDetails { get; set; }

    public virtual DbSet<CourierLocationMapping> CourierLocationMappings { get; set; }

    public virtual DbSet<CourierService> CourierServices { get; set; }

    public virtual DbSet<CpCustomerCatAssign> CpCustomerCatAssigns { get; set; }

    public virtual DbSet<CpCustomerInfo> CpCustomerInfos { get; set; }

    public virtual DbSet<CpCustomerOrder> CpCustomerOrders { get; set; }

    public virtual DbSet<CpCustomerOrderDetail> CpCustomerOrderDetails { get; set; }

    public virtual DbSet<CpImage> CpImages { get; set; }

    public virtual DbSet<CpNotification> CpNotifications { get; set; }

    public virtual DbSet<CpOrderHistory> CpOrderHistories { get; set; }

    public virtual DbSet<CpProductInfo> CpProductInfos { get; set; }

    public virtual DbSet<CpSellerInfo> CpSellerInfos { get; set; }

    public virtual DbSet<CpSellerLcatAssign> CpSellerLcatAssigns { get; set; }

    public virtual DbSet<CpVersion> CpVersions { get; set; }

    public virtual DbSet<CustomerAssignedService> CustomerAssignedServices { get; set; }

    public virtual DbSet<CustomerInfo> CustomerInfos { get; set; }

    public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }

    public virtual DbSet<CustomerOrderDetail> CustomerOrderDetails { get; set; }

    public virtual DbSet<DeliveryChargesMatrix> DeliveryChargesMatrices { get; set; }

    public virtual DbSet<DeliveryMode> DeliveryModes { get; set; }

    public virtual DbSet<DestinationCity> DestinationCities { get; set; }

    public virtual DbSet<DiscountPrice> DiscountPrices { get; set; }

    public virtual DbSet<DummyScheduler> DummySchedulers { get; set; }

    public virtual DbSet<DvchargesCriterion> DvchargesCriteria { get; set; }

    public virtual DbSet<DvchargesMaster> DvchargesMasters { get; set; }

    public virtual DbSet<DvchargesSetup> DvchargesSetups { get; set; }

    public virtual DbSet<DvchargesSlab> DvchargesSlabs { get; set; }

    public virtual DbSet<ErrorLogApi> ErrorLogApis { get; set; }

    public virtual DbSet<HitCount> HitCounts { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<IshoppingOrder> IshoppingOrders { get; set; }

    public virtual DbSet<ItemBundle> ItemBundles { get; set; }

    public virtual DbSet<ItemCapping> ItemCappings { get; set; }

    public virtual DbSet<ItemCategory> ItemCategories { get; set; }

    public virtual DbSet<ItemCategory1> ItemCategories1 { get; set; }

    public virtual DbSet<ItemDescription> ItemDescriptions { get; set; }

    public virtual DbSet<ItemDiscount> ItemDiscounts { get; set; }

    public virtual DbSet<ItemFulfill> ItemFulfills { get; set; }

    public virtual DbSet<ItemGeneric> ItemGenerics { get; set; }

    public virtual DbSet<ItemImagesLink> ItemImagesLinks { get; set; }

    public virtual DbSet<ItemLogo> ItemLogos { get; set; }

    public virtual DbSet<ItemStock> ItemStocks { get; set; }

    public virtual DbSet<ItemStockLocation> ItemStockLocations { get; set; }

    public virtual DbSet<ItemStockLog> ItemStockLogs { get; set; }

    public virtual DbSet<ItemType> ItemTypes { get; set; }

    public virtual DbSet<LeverageSale> LeverageSales { get; set; }

    public virtual DbSet<MajorCategory> MajorCategories { get; set; }

    public virtual DbSet<MasterCategory> MasterCategories { get; set; }

    public virtual DbSet<MasterDdList> MasterDdLists { get; set; }

    public virtual DbSet<MasterItem> MasterItems { get; set; }

    public virtual DbSet<MasterItem1> MasterItems1 { get; set; }

    public virtual DbSet<MasterItem2> MasterItems2 { get; set; }

    public virtual DbSet<MasterItemDetail> MasterItemDetails { get; set; }

    public virtual DbSet<MasterOrder> MasterOrders { get; set; }

    public virtual DbSet<MasterOrderLog> MasterOrderLogs { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuAssignedMenu> MenuAssignedMenus { get; set; }

    public virtual DbSet<MenuChild> MenuChildren { get; set; }

    public virtual DbSet<MenuChildTest> MenuChildTests { get; set; }

    public virtual DbSet<MenuParent> MenuParents { get; set; }

    public virtual DbSet<MenuParentTest> MenuParentTests { get; set; }

    public virtual DbSet<MenuSubchild> MenuSubchildren { get; set; }

    public virtual DbSet<MnpLocation> MnpLocations { get; set; }

    public virtual DbSet<MobileAppInfo> MobileAppInfos { get; set; }

    public virtual DbSet<ModelReview> ModelReviews { get; set; }

    public virtual DbSet<ModelSpecification> ModelSpecifications { get; set; }

    public virtual DbSet<MplBookingDetail> MplBookingDetails { get; set; }

    public virtual DbSet<Newsletter> Newsletters { get; set; }

    public virtual DbSet<ORiderBooking> ORiderBookings { get; set; }

    public virtual DbSet<ORiderBookingTemp> ORiderBookingTemps { get; set; }

    public virtual DbSet<ORiderOrderTracking> ORiderOrderTrackings { get; set; }

    public virtual DbSet<ORiderPreferedArea> ORiderPreferedAreas { get; set; }

    public virtual DbSet<OrderAttribute> OrderAttributes { get; set; }

    public virtual DbSet<OrderDelivery> OrderDeliveries { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderDetailApptak> OrderDetailApptaks { get; set; }

    public virtual DbSet<OrderDetailBackup> OrderDetailBackups { get; set; }

    public virtual DbSet<OrderDetailLog> OrderDetailLogs { get; set; }

    public virtual DbSet<OrderDvchargesDetail> OrderDvchargesDetails { get; set; }

    public virtual DbSet<OrderHead> OrderHeads { get; set; }

    public virtual DbSet<OrderHeadApptak> OrderHeadApptaks { get; set; }

    public virtual DbSet<OrderHeadBackup> OrderHeadBackups { get; set; }

    public virtual DbSet<OrderHeadLog> OrderHeadLogs { get; set; }

    public virtual DbSet<OrderPrescription> OrderPrescriptions { get; set; }

    public virtual DbSet<OrderReturned> OrderReturneds { get; set; }

    public virtual DbSet<OrderShipment> OrderShipments { get; set; }

    public virtual DbSet<OrderStationary> OrderStationaries { get; set; }

    public virtual DbSet<OrderStationaryLog> OrderStationaryLogs { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<OrderStatusBackup> OrderStatusBackups { get; set; }

    public virtual DbSet<OrderTrackingLog> OrderTrackingLogs { get; set; }

    public virtual DbSet<OriginCity> OriginCities { get; set; }

    public virtual DbSet<PaymentGateway> PaymentGateways { get; set; }

    public virtual DbSet<PaymentMode> PaymentModes { get; set; }

    public virtual DbSet<PaymentTransResponse> PaymentTransResponses { get; set; }

    public virtual DbSet<PfzHcplist> PfzHcplists { get; set; }

    public virtual DbSet<PfzItemMap> PfzItemMaps { get; set; }

    public virtual DbSet<PharmaCancelReason> PharmaCancelReasons { get; set; }

    public virtual DbSet<PrepaidBillReference> PrepaidBillReferences { get; set; }

    public virtual DbSet<PriceFilter> PriceFilters { get; set; }

    public virtual DbSet<ProductPromotion> ProductPromotions { get; set; }

    public virtual DbSet<PromoDetail> PromoDetails { get; set; }

    public virtual DbSet<ProvincialTaxationScheme> ProvincialTaxationSchemes { get; set; }

    public virtual DbSet<PspAuditApi> PspAuditApis { get; set; }

    public virtual DbSet<PspCancellationReason> PspCancellationReasons { get; set; }

    public virtual DbSet<ReconcilliationTable> ReconcilliationTables { get; set; }

    public virtual DbSet<RiderAppDocument> RiderAppDocuments { get; set; }

    public virtual DbSet<RiderBooking> RiderBookings { get; set; }

    public virtual DbSet<RiderOrderTracking> RiderOrderTrackings { get; set; }

    public virtual DbSet<RiderPreferedArea> RiderPreferedAreas { get; set; }

    public virtual DbSet<RiderProgess> RiderProgesses { get; set; }

    public virtual DbSet<SellCategory> SellCategories { get; set; }

    public virtual DbSet<Seller> Sellers { get; set; }

    public virtual DbSet<SellerInfo> SellerInfos { get; set; }

    public virtual DbSet<SellerOrder> SellerOrders { get; set; }

    public virtual DbSet<SellerOrderArchive> SellerOrderArchives { get; set; }

    public virtual DbSet<SellerOrderDetail> SellerOrderDetails { get; set; }

    public virtual DbSet<SellerOrderDetailArchive> SellerOrderDetailArchives { get; set; }

    public virtual DbSet<SellerPaymentDetail> SellerPaymentDetails { get; set; }

    public virtual DbSet<SellerPaymentHead> SellerPaymentHeads { get; set; }

    public virtual DbSet<SellerSetting> SellerSettings { get; set; }

    public virtual DbSet<SeoMapping> SeoMappings { get; set; }

    public virtual DbSet<ServiceCenter> ServiceCenters { get; set; }

    public virtual DbSet<ServiceType> ServiceTypes { get; set; }

    public virtual DbSet<SghConsignmentsError> SghConsignmentsErrors { get; set; }

    public virtual DbSet<SghEorderLinesStatus> SghEorderLinesStatuses { get; set; }

    public virtual DbSet<SghEorderStatus> SghEorderStatuses { get; set; }

    public virtual DbSet<SghEorderStatusStg> SghEorderStatusStgs { get; set; }

    public virtual DbSet<SghOrder> SghOrders { get; set; }

    public virtual DbSet<SghOrderBillingaddress> SghOrderBillingaddresses { get; set; }

    public virtual DbSet<SghOrderBillingaddress27052022> SghOrderBillingaddress27052022s { get; set; }

    public virtual DbSet<SghOrderBillingaddressStg> SghOrderBillingaddressStgs { get; set; }

    public virtual DbSet<SghOrderBillingaddressTst> SghOrderBillingaddressTsts { get; set; }

    public virtual DbSet<SghOrderConsignment> SghOrderConsignments { get; set; }

    public virtual DbSet<SghOrderConsignments27052022> SghOrderConsignments27052022s { get; set; }

    public virtual DbSet<SghOrderConsignmentsStg> SghOrderConsignmentsStgs { get; set; }

    public virtual DbSet<SghOrderConsignmentsTst> SghOrderConsignmentsTsts { get; set; }

    public virtual DbSet<SghOrderCustomer> SghOrderCustomers { get; set; }

    public virtual DbSet<SghOrderCustomers27052022> SghOrderCustomers27052022s { get; set; }

    public virtual DbSet<SghOrderCustomersStg> SghOrderCustomersStgs { get; set; }

    public virtual DbSet<SghOrderCustomersTst> SghOrderCustomersTsts { get; set; }

    public virtual DbSet<SghOrderDiscount> SghOrderDiscounts { get; set; }

    public virtual DbSet<SghOrderDiscounts27052022> SghOrderDiscounts27052022s { get; set; }

    public virtual DbSet<SghOrderDiscountsStg> SghOrderDiscountsStgs { get; set; }

    public virtual DbSet<SghOrderDiscountsTst> SghOrderDiscountsTsts { get; set; }

    public virtual DbSet<SghOrderPayment> SghOrderPayments { get; set; }

    public virtual DbSet<SghOrderPaymentAddInfo> SghOrderPaymentAddInfos { get; set; }

    public virtual DbSet<SghOrderPaymentAddInfo27052022> SghOrderPaymentAddInfo27052022s { get; set; }

    public virtual DbSet<SghOrderPaymentAddInfoStg> SghOrderPaymentAddInfoStgs { get; set; }

    public virtual DbSet<SghOrderPayments27052022> SghOrderPayments27052022s { get; set; }

    public virtual DbSet<SghOrderPaymentsStg> SghOrderPaymentsStgs { get; set; }

    public virtual DbSet<SghOrderShippingaddress> SghOrderShippingaddresses { get; set; }

    public virtual DbSet<SghOrderShippingaddress27052022> SghOrderShippingaddress27052022s { get; set; }

    public virtual DbSet<SghOrderShippingaddressStg> SghOrderShippingaddressStgs { get; set; }

    public virtual DbSet<SghOrderShippingaddressTst> SghOrderShippingaddressTsts { get; set; }

    public virtual DbSet<SghOrderStatus> SghOrderStatuses { get; set; }

    public virtual DbSet<SghOrderStatusStg> SghOrderStatusStgs { get; set; }

    public virtual DbSet<SghOrderTaxes27052022> SghOrderTaxes27052022s { get; set; }

    public virtual DbSet<SghOrderTaxesStg> SghOrderTaxesStgs { get; set; }

    public virtual DbSet<SghOrderTaxesTst> SghOrderTaxesTsts { get; set; }

    public virtual DbSet<SghOrderTaxis> SghOrderTaxes { get; set; }

    public virtual DbSet<SghOrders27052022> SghOrders27052022s { get; set; }

    public virtual DbSet<SghOrdersArc> SghOrdersArcs { get; set; }

    public virtual DbSet<SghOrdersLog> SghOrdersLogs { get; set; }

    public virtual DbSet<SghOrdersLog27052022> SghOrdersLog27052022s { get; set; }

    public virtual DbSet<SghOrdersLogStg> SghOrdersLogStgs { get; set; }

    public virtual DbSet<SghOrdersLogTst> SghOrdersLogTsts { get; set; }

    public virtual DbSet<SghOrdersLogTst13052022> SghOrdersLogTst13052022s { get; set; }

    public virtual DbSet<SghOrdersPod> SghOrdersPods { get; set; }

    public virtual DbSet<SghOrdersPod27052022> SghOrdersPod27052022s { get; set; }

    public virtual DbSet<SghOrdersPodStg> SghOrdersPodStgs { get; set; }

    public virtual DbSet<SghOrdersStg> SghOrdersStgs { get; set; }

    public virtual DbSet<SghOrdersTst> SghOrdersTsts { get; set; }

    public virtual DbSet<SghReserveSku> SghReserveSkus { get; set; }

    public virtual DbSet<SghReserveSkuStg> SghReserveSkuStgs { get; set; }

    public virtual DbSet<SghSkuCode> SghSkuCodes { get; set; }

    public virtual DbSet<SghSkuCodeBkup20072024> SghSkuCodeBkup20072024s { get; set; }

    public virtual DbSet<SghSkuCodeStg> SghSkuCodeStgs { get; set; }

    public virtual DbSet<SghSkuStockDepot> SghSkuStockDepots { get; set; }

    public virtual DbSet<SghSkuTmp> SghSkuTmps { get; set; }

    public virtual DbSet<SghSplitOrderDetail> SghSplitOrderDetails { get; set; }

    public virtual DbSet<SghSplitOrderDetails27052022> SghSplitOrderDetails27052022s { get; set; }

    public virtual DbSet<SghSplitOrderDetailsStg> SghSplitOrderDetailsStgs { get; set; }

    public virtual DbSet<SghSplitOrderReturn> SghSplitOrderReturns { get; set; }

    public virtual DbSet<SghSplitOrderReturns27052022> SghSplitOrderReturns27052022s { get; set; }

    public virtual DbSet<SghSplitOrderReturnsStg> SghSplitOrderReturnsStgs { get; set; }

    public virtual DbSet<SghSplitOrdersHeader> SghSplitOrdersHeaders { get; set; }

    public virtual DbSet<SghSplitOrdersHeader27052022> SghSplitOrdersHeader27052022s { get; set; }

    public virtual DbSet<SghSplitOrdersHeaderStg> SghSplitOrdersHeaderStgs { get; set; }

    public virtual DbSet<Sheet1> Sheet1s { get; set; }

    public virtual DbSet<Slider> Sliders { get; set; }

    public virtual DbSet<SliderPromotion> SliderPromotions { get; set; }

    public virtual DbSet<SmItemMaster> SmItemMasters { get; set; }

    public virtual DbSet<SmItemMaster1> SmItemMaster1s { get; set; }

    public virtual DbSet<SmPspOrder> SmPspOrders { get; set; }

    public virtual DbSet<SmPspOrderDetail> SmPspOrderDetails { get; set; }

    public virtual DbSet<SmsContent> SmsContents { get; set; }

    public virtual DbSet<SmsContentTemp> SmsContentTemps { get; set; }

    public virtual DbSet<SmsLog> SmsLogs { get; set; }

    public virtual DbSet<SmsPendingQueue> SmsPendingQueues { get; set; }

    public virtual DbSet<SmsStatus> SmsStatuses { get; set; }

    public virtual DbSet<StationaryItem> StationaryItems { get; set; }

    public virtual DbSet<StockPickupPointAreaAssign> StockPickupPointAreaAssigns { get; set; }

    public virtual DbSet<StockPickupPointBackup> StockPickupPointBackups { get; set; }

    public virtual DbSet<StockPickupPointSellCategory> StockPickupPointSellCategories { get; set; }

    public virtual DbSet<StockPickuppoint> StockPickuppoints { get; set; }

    public virtual DbSet<StockPickuppoint1> StockPickuppoint1s { get; set; }

    public virtual DbSet<StockPosition> StockPositions { get; set; }

    public virtual DbSet<StockPositionLog> StockPositionLogs { get; set; }

    public virtual DbSet<SubCategory> SubCategories { get; set; }

    public virtual DbSet<SubCategory1> SubCategories1 { get; set; }

    public virtual DbSet<SystemCode> SystemCodes { get; set; }

    public virtual DbSet<SzOrderDetail> SzOrderDetails { get; set; }

    public virtual DbSet<TaUser> TaUsers { get; set; }

    public virtual DbSet<TaUsers13012023> TaUsers13012023s { get; set; }

    public virtual DbSet<TaUsersAdmin> TaUsersAdmins { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TaxSlab> TaxSlabs { get; set; }

    public virtual DbSet<TblImage> TblImages { get; set; }

    public virtual DbSet<TblImagesItem> TblImagesItems { get; set; }

    public virtual DbSet<TblPspAttachment> TblPspAttachments { get; set; }

    public virtual DbSet<TblXiaomiOrder> TblXiaomiOrders { get; set; }

    public virtual DbSet<TempB2bOutlet> TempB2bOutlets { get; set; }

    public virtual DbSet<TempB2bOutlets2> TempB2bOutlets2s { get; set; }

    public virtual DbSet<TempChildItem> TempChildItems { get; set; }

    public virtual DbSet<TempCustomerCatAssign> TempCustomerCatAssigns { get; set; }

    public virtual DbSet<TempIbft> TempIbfts { get; set; }

    public virtual DbSet<TempIbft2> TempIbft2s { get; set; }

    public virtual DbSet<TempItemCategory> TempItemCategories { get; set; }

    public virtual DbSet<TempItemDescription> TempItemDescriptions { get; set; }

    public virtual DbSet<TempItemStock> TempItemStocks { get; set; }

    public virtual DbSet<TempMasterItem> TempMasterItems { get; set; }

    public virtual DbSet<TempNovoOrderStatus> TempNovoOrderStatuses { get; set; }

    public virtual DbSet<TempProductInfo> TempProductInfos { get; set; }

    public virtual DbSet<TmpApCitem> TmpApCitems { get; set; }

    public virtual DbSet<TmpApIcat> TmpApIcats { get; set; }

    public virtual DbSet<TmpApMitem> TmpApMitems { get; set; }

    public virtual DbSet<TmpApptakCor> TmpApptakCors { get; set; }

    public virtual DbSet<TmpApptakItem> TmpApptakItems { get; set; }

    public virtual DbSet<TmpApptakPrice> TmpApptakPrices { get; set; }

    public virtual DbSet<TmpBhCitem> TmpBhCitems { get; set; }

    public virtual DbSet<TmpBhIcat> TmpBhIcats { get; set; }

    public virtual DbSet<TmpBhMitem> TmpBhMitems { get; set; }

    public virtual DbSet<TmpBhitemsUpdate> TmpBhitemsUpdates { get; set; }

    public virtual DbSet<TmpFwCitem> TmpFwCitems { get; set; }

    public virtual DbSet<TmpFwIcat> TmpFwIcats { get; set; }

    public virtual DbSet<TmpFwMitem> TmpFwMitems { get; set; }

    public virtual DbSet<TmpGeneric> TmpGenerics { get; set; }

    public virtual DbSet<TmpGrCitem> TmpGrCitems { get; set; }

    public virtual DbSet<TmpGrIcat> TmpGrIcats { get; set; }

    public virtual DbSet<TmpGrItem> TmpGrItems { get; set; }

    public virtual DbSet<TmpGrStk> TmpGrStks { get; set; }

    public virtual DbSet<TmpItemBundle> TmpItemBundles { get; set; }

    public virtual DbSet<TmpMedic> TmpMedics { get; set; }

    public virtual DbSet<TmpNcareRider> TmpNcareRiders { get; set; }

    public virtual DbSet<TmpNovoCanceled> TmpNovoCanceleds { get; set; }

    public virtual DbSet<TmpNovoCancelled> TmpNovoCancelleds { get; set; }

    public virtual DbSet<TmpNovoDelivered> TmpNovoDelivereds { get; set; }

    public virtual DbSet<TmpNovoDispatched> TmpNovoDispatcheds { get; set; }

    public virtual DbSet<TmpNovoDsr> TmpNovoDsrs { get; set; }

    public virtual DbSet<TmpNovoOrder> TmpNovoOrders { get; set; }

    public virtual DbSet<TmpNovoOrderStatus> TmpNovoOrderStatuses { get; set; }

    public virtual DbSet<TmpNovoOrderStatus2> TmpNovoOrderStatus2s { get; set; }

    public virtual DbSet<TmpNovoReturned> TmpNovoReturneds { get; set; }

    public virtual DbSet<TmpNovoRider> TmpNovoRiders { get; set; }

    public virtual DbSet<TmpNovoStatus> TmpNovoStatuses { get; set; }

    public virtual DbSet<TmpOrder> TmpOrders { get; set; }

    public virtual DbSet<TmpOrderCon> TmpOrderCons { get; set; }

    public virtual DbSet<TmpOrderCons1> TmpOrderCons1s { get; set; }

    public virtual DbSet<TmpOrderCons2> TmpOrderCons2s { get; set; }

    public virtual DbSet<TmpOrderCons3> TmpOrderCons3s { get; set; }

    public virtual DbSet<TmpOrderCons4> TmpOrderCons4s { get; set; }

    public virtual DbSet<TmpPharmaUpload> TmpPharmaUploads { get; set; }

    public virtual DbSet<TmpRider> TmpRiders { get; set; }

    public virtual DbSet<TmpSghItem> TmpSghItems { get; set; }

    public virtual DbSet<TmpSghItem1807> TmpSghItem1807s { get; set; }

    public virtual DbSet<TmpSghItem20072024> TmpSghItem20072024s { get; set; }

    public virtual DbSet<TmpSghItemF1> TmpSghItemF1s { get; set; }

    public virtual DbSet<TmpSghItemFinal24> TmpSghItemFinal24s { get; set; }

    public virtual DbSet<TmpSghItemNew> TmpSghItemNews { get; set; }

    public virtual DbSet<TmpSghItems200724> TmpSghItems200724s { get; set; }

    public virtual DbSet<TmpSghOrderRe> TmpSghOrderRes { get; set; }

    public virtual DbSet<TmpSkuCe> TmpSkuCes { get; set; }

    public virtual DbSet<TmpZamCitem> TmpZamCitems { get; set; }

    public virtual DbSet<TmpZamIcat> TmpZamIcats { get; set; }

    public virtual DbSet<TmpZamMitem> TmpZamMitems { get; set; }

    public virtual DbSet<UniLever> UniLevers { get; set; }

    public virtual DbSet<UplSku> UplSkus { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAddress> UserAddresses { get; set; }

    public virtual DbSet<UserAssignPickuppoint> UserAssignPickuppoints { get; set; }

    public virtual DbSet<UserCart> UserCarts { get; set; }

    public virtual DbSet<UserLoginAudit> UserLoginAudits { get; set; }

    public virtual DbSet<UserPermission> UserPermissions { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<UserWishlist> UserWishlists { get; set; }

    public virtual DbSet<VendorOrder> VendorOrders { get; set; }

    public virtual DbSet<VendorOrderLog> VendorOrderLogs { get; set; }

    public virtual DbSet<VendorPrincipalDiscount> VendorPrincipalDiscounts { get; set; }

    public virtual DbSet<VendorPrincipalMapping> VendorPrincipalMappings { get; set; }

    public virtual DbSet<VendorProductDiscount> VendorProductDiscounts { get; set; }

    public virtual DbSet<VpblImeiDatum> VpblImeiData { get; set; }

    public virtual DbSet<WebsiteInfo> WebsiteInfos { get; set; }

    public virtual DbSet<XxAddArea> XxAddAreas { get; set; }

    public virtual DbSet<XxAddCity> XxAddCities { get; set; }

    public virtual DbSet<XxAddCountry> XxAddCountries { get; set; }

    public virtual DbSet<XxAddProvince> XxAddProvinces { get; set; }

    public virtual DbSet<XxCompany> XxCompanies { get; set; }

    public virtual DbSet<XxMasterOrder20191129> XxMasterOrder20191129s { get; set; }

    public virtual DbSet<XxMasterOrder20191204> XxMasterOrder20191204s { get; set; }

    public virtual DbSet<XxMasterOrder26112019> XxMasterOrder26112019s { get; set; }

    public virtual DbSet<XxOrderDetail20191125> XxOrderDetail20191125s { get; set; }

    public virtual DbSet<XxOrderHead20191125> XxOrderHead20191125s { get; set; }

    public virtual DbSet<XxOrderHead20191129> XxOrderHead20191129s { get; set; }

    public virtual DbSet<XxOrderHead20191216> XxOrderHead20191216s { get; set; }

    public virtual DbSet<XxProdHeirarchyUpl> XxProdHeirarchyUpls { get; set; }

    public virtual DbSet<XxScotchBright3m> XxScotchBright3ms { get; set; }

    public virtual DbSet<XxSellCategory> XxSellCategories { get; set; }

    public virtual DbSet<XxSubChildTest> XxSubChildTests { get; set; }

    public virtual DbSet<XxTaUsers02122019> XxTaUsers02122019s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:apptak.database.windows.net,1433;Database=Apptak-DB;User ID=apptak_admin;Password=N1ot+uloS-;Trusted_Connection=False;Pooling=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AbtSkuCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abt_sku_code");

            entity.Property(e => e.AbtSkuCode1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("abt_sku_code");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("active");
            entity.Property(e => e.ChItem)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ch_item");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
        });

        modelBuilder.Entity<AddArea>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.CountryId, e.ProvinceId, e.CityId, e.AreaId }).HasName("PK_AREA");

            entity.ToTable("ADD_AREA");

            entity.HasIndex(e => new { e.AreaId, e.CityId, e.CountryId, e.ProvinceId }, "nci_wi_ADD_AREA_F39B5550E49611FB72DE7614B49FBBC2").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.AreaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Area_ID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Area_Name");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.GpsCoordinates)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GPS_COORDINATES");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.AddAreas)
                .HasForeignKey(d => d.Company)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AREA_C");

            entity.HasOne(d => d.AddCountry).WithMany(p => p.AddAreas)
                .HasForeignKey(d => new { d.Company, d.CountryId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AREA_COUNTRY");

            entity.HasOne(d => d.AddProvince).WithMany(p => p.AddAreas)
                .HasForeignKey(d => new { d.Company, d.CountryId, d.ProvinceId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AREA_PROVINCE");

            entity.HasOne(d => d.AddCity).WithMany(p => p.AddAreas)
                .HasForeignKey(d => new { d.Company, d.CountryId, d.ProvinceId, d.CityId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AREA_CITY");
        });

        modelBuilder.Entity<AddCity>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.CountryId, e.ProvinceId, e.CityId }).HasName("PK_CITY");

            entity.ToTable("ADD_CITY");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.CityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("City_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name");
            entity.Property(e => e.CityNameTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name_Title");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.AddCities)
                .HasForeignKey(d => d.Company)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CITY_C");

            entity.HasOne(d => d.AddCountry).WithMany(p => p.AddCities)
                .HasForeignKey(d => new { d.Company, d.CountryId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CITY_COUNTRY");

            entity.HasOne(d => d.AddProvince).WithMany(p => p.AddCities)
                .HasForeignKey(d => new { d.Company, d.CountryId, d.ProvinceId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CITY_PROVINCE");
        });

        modelBuilder.Entity<AddCountry>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.CountryId }).HasName("PK_COUNTRY");

            entity.ToTable("ADD_COUNTRY");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CountryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Country_ID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Country_Name");
            entity.Property(e => e.CountryNameTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Country_Name_Title");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.AddCountries)
                .HasForeignKey(d => d.Company)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COUNTRY_C");
        });

        modelBuilder.Entity<AddProvince>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.CountryId, e.ProvinceId }).HasName("PK_PROVINCE");

            entity.ToTable("ADD_PROVINCE");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.ProvinceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Province_ID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Province_NAME");
            entity.Property(e => e.ProvinceNameTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Province_NAME_TITLE");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.AddProvinces)
                .HasForeignKey(d => d.Company)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVINCE_C");

            entity.HasOne(d => d.AddCountry).WithMany(p => p.AddProvinces)
                .HasForeignKey(d => new { d.Company, d.CountryId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVINCE_COUNTRY");
        });

        modelBuilder.Entity<AglAuditApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL_AUDIT_API");

            entity.Property(e => e.AccessDate)
                .HasColumnType("datetime")
                .HasColumnName("ACCESS_DATE");
            entity.Property(e => e.ActionName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ACTION_NAME");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.MethodName)
                .IsUnicode(false)
                .HasColumnName("METHOD_NAME");
            entity.Property(e => e.OrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.ResponseData)
                .IsUnicode(false)
                .HasColumnName("RESPONSE_DATA");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<AglOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL_ORDERS");

            entity.HasIndex(e => e.AgilityOrderId, "nci_wi_AGL_ORDERS_C27C3ACB6967A7150455EDF992CBC1AA");

            entity.Property(e => e.AgilityOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agilityOrderId");
            entity.Property(e => e.AglStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agl_status");
            entity.Property(e => e.ApptakrefNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apptakref_num");
            entity.Property(e => e.BaCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_city");
            entity.Property(e => e.BaCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_companyName");
            entity.Property(e => e.BaContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_contactName");
            entity.Property(e => e.BaContactPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ba_contactPhone");
            entity.Property(e => e.BaCountry)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ba_country");
            entity.Property(e => e.BaLine1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ba_line1");
            entity.Property(e => e.BaLine2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ba_line2");
            entity.Property(e => e.BaPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ba_postalCode");
            entity.Property(e => e.BaState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_state");
            entity.Property(e => e.CancelReason).HasColumnName("cancel_reason");
            entity.Property(e => e.Cnic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.ConsignmentNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_num");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.CsCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_companyName");
            entity.Property(e => e.CsCustomerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_customerId");
            entity.Property(e => e.CsEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_email");
            entity.Property(e => e.CsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_name");
            entity.Property(e => e.CsPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cs_phone");
            entity.Property(e => e.CsTitle)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cs_title");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("deliveryMethod");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.DestinationId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("destinationId");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.LoadsheetrefNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loadsheetref_num");
            entity.Property(e => e.MnpAssignedDepotId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("mnp_assignedDepotID");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.OrdershippedDt)
                .HasColumnType("datetime")
                .HasColumnName("ordershipped_dt");
            entity.Property(e => e.Paymentmode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("paymentmode");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<AglOrderCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL_ORDER_CITY");

            entity.Property(e => e.CityCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CITY_CODE");
            entity.Property(e => e.CityName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CITY_NAME");
            entity.Property(e => e.MnpCityCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MNP_CITY_CODE");
            entity.Property(e => e.ShortName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SHORT_NAME");
        });

        modelBuilder.Entity<AglOrderConsignment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL_ORDER_CONSIGNMENTS");

            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.DiscAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discAmount");
            entity.Property(e => e.DiscRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discRate");
            entity.Property(e => e.IncFeeAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("incFeeAmount");
            entity.Property(e => e.IncTaxAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("incTaxAmount");
            entity.Property(e => e.LineItemId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("lineItemId");
            entity.Property(e => e.LineItemTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("lineItemTotal");
            entity.Property(e => e.Price)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantity");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxRate");
        });

        modelBuilder.Entity<AglOrderLoadsheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL_ORDER_LOADSHEETS");

            entity.Property(e => e.Agilityorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AGILITYORDERID");
            entity.Property(e => e.ConsignmentNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONSIGNMENT_NUM");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Deliveryorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DELIVERYORDERID");
            entity.Property(e => e.LmdloadsheetNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LMDLOADSHEET_NUM");
            entity.Property(e => e.LoadsheetNum)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LOADSHEET_NUM");
            entity.Property(e => e.Updatedon)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDON");
        });

        modelBuilder.Entity<AglOrderStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL_ORDER_STATUS");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_Description");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");
        });

        modelBuilder.Entity<AglReturnsReasonCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL_RETURNS_REASON_CODE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REASON_CODE");
        });

        modelBuilder.Entity<AglSkuCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL_SKU_CODE");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.StockQty)
                .HasDefaultValue(0)
                .HasColumnName("STOCK_QTY");
            entity.Property(e => e.StockQtyEstore).HasColumnName("STOCK_QTY_ESTORE");
        });

        modelBuilder.Entity<AglSkuCodeBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL_SKU_CODE_BK");

            entity.Property(e => e.Active).HasMaxLength(255);
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .HasColumnName("SGH_SKU_CODE");
        });

        modelBuilder.Entity<ApiEndpoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ApiEndpo__3214EC07A13A173E");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Route).HasMaxLength(500);
        });

        modelBuilder.Entity<ApptakUserRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("APPTAK_USER_ROLES");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATED_By");
            entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");
            entity.Property(e => e.Division)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DIVISION");
            entity.Property(e => e.Isvendor).HasColumnName("ISVENDOR");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_By");
            entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.Principal)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PRINCIPAL");
            entity.Property(e => e.RCode)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("R_CODE");
            entity.Property(e => e.RName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("R_NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Vendor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("VENDOR");
        });

        modelBuilder.Entity<AssignCustomersUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("assign_customers_user");

            entity.Property(e => e.Createdby).HasMaxLength(20);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("iD");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<B2bAuditApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("B2B_AUDIT_API");

            entity.Property(e => e.AccessDate)
                .HasColumnType("datetime")
                .HasColumnName("ACCESS_DATE");
            entity.Property(e => e.ActionName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ACTION_NAME");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.MethodName)
                .IsUnicode(false)
                .HasColumnName("METHOD_NAME");
            entity.Property(e => e.OrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.ResponseData)
                .IsUnicode(false)
                .HasColumnName("RESPONSE_DATA");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<B2bEcommerceSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("B2B_ECOMMERCE_SALES");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BuyerCnic)
                .HasMaxLength(255)
                .HasColumnName("BuyerCNIC");
            entity.Property(e => e.BuyerCode).HasMaxLength(255);
            entity.Property(e => e.BuyerName).HasMaxLength(255);
            entity.Property(e => e.BuyerNtn)
                .HasMaxLength(255)
                .HasColumnName("BuyerNTN");
            entity.Property(e => e.BuyerStrn)
                .HasMaxLength(255)
                .HasColumnName("BuyerSTRN");
            entity.Property(e => e.CartonSize).HasMaxLength(255);
            entity.Property(e => e.ContactNumber).HasMaxLength(255);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.Gst).HasColumnName("GST");
            entity.Property(e => e.LeverageCashmemo).HasMaxLength(255);
            entity.Property(e => e.LeverageCashmemoDate).HasColumnType("datetime");
            entity.Property(e => e.LeverageCustomerCode).HasMaxLength(255);
            entity.Property(e => e.LeverageCustomerName).HasMaxLength(255);
            entity.Property(e => e.MrpexcludeTax).HasColumnName("MRPExcludeTax");
            entity.Property(e => e.MrpincludeTax).HasColumnName("MRPIncludeTax");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(255)
                .HasColumnName("OrderID");
            entity.Property(e => e.ProductDesc).HasMaxLength(255);
            entity.Property(e => e.QuantityInPc).HasColumnName("QuantityInPC");
            entity.Property(e => e.TaxType).HasMaxLength(255);
            entity.Property(e => e.VendorCode).HasMaxLength(255);
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<BkChildItem020723>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bk_child_item_020723");

            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM_FULL_NAME");
            entity.Property(e => e.ChItemShortName)
                .HasMaxLength(50)
                .HasColumnName("CH_ITEM_SHORT_NAME");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<BkMasterItem020723>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bk_master_item_020723");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Delivery)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.ImageUrl).HasColumnName("IMAGE_URL");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Item1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item1Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM1_NAME");
            entity.Property(e => e.Item2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM2");
            entity.Property(e => e.Item2Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM2_NAME");
            entity.Property(e => e.Item3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM3");
            entity.Property(e => e.Item3Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM3_NAME");
            entity.Property(e => e.Item4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM4");
            entity.Property(e => e.Item4Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM4_NAME");
            entity.Property(e => e.Item5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM5");
            entity.Property(e => e.Item5Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM5_NAME");
            entity.Property(e => e.Item6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM6");
            entity.Property(e => e.Item6Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM6_NAME");
            entity.Property(e => e.Item7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM7");
            entity.Property(e => e.Item7Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM7_NAME");
            entity.Property(e => e.Item8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM8");
            entity.Property(e => e.Item8Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM8_NAME");
            entity.Property(e => e.Item9)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM9");
            entity.Property(e => e.Item9Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM9_NAME");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ITEM_FULL_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.Prescription).HasColumnName("PRESCRIPTION");
            entity.Property(e => e.Productlink)
                .IsUnicode(false)
                .HasColumnName("PRODUCTLINK");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Seller)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<BkOrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bk_order_detail");

            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.MrspNew)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("MRSP_NEW");
            entity.Property(e => e.MrspOld)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("MRSP_OLD");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_COST");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.PrecriptionImg).HasColumnName("PRECRIPTION_IMG");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELL_CATEGORY");
        });

        modelBuilder.Entity<BkSghOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BK_SGH_ORDERS");

            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.MnpStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("mnp_status");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("partnerOrderId");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.RmsStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("rms_status");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<BkSghOrderConsignment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BK_SGH_ORDER_CONSIGNMENTS");

            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("consignmentId");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.LineItemTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("lineItemTotal");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantity");
            entity.Property(e => e.RegularRetailPrice)
                .HasColumnType("numeric(19, 0)")
                .HasColumnName("regularRetailPrice");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.WarehouseId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("warehouseId");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Brand");

            entity.Property(e => e.BrandCode)
                .ValueGeneratedOnAdd()
                .HasColumnName("Brand_CODE");
            entity.Property(e => e.BrandName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Brand_NAME");
            entity.Property(e => e.CategoryCode).HasColumnName("Category_CODE");
            entity.Property(e => e.CompanyCode).HasColumnName("COMPANY_CODE");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.DateModify).HasColumnName("Date_Modify");
            entity.Property(e => e.RefernceCategory)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Refernce_Category");
            entity.Property(e => e.ReferncePrincipal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Refernce_Principal");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SubCategoryCode).HasColumnName("SubCategory_CODE");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Entry");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Category");

            entity.Property(e => e.CategoryCode)
                .ValueGeneratedOnAdd()
                .HasColumnName("Category_CODE");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Category_NAME");
            entity.Property(e => e.CompanyCode).HasColumnName("COMPANY_CODE");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.DateModify).HasColumnName("Date_Modify");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Entry");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<CellOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cell_order");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Bank)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("bank");
            entity.Property(e => e.City)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Cnic)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.Color)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.ConsignmentNumber).HasMaxLength(50);
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("contactNumber");
            entity.Property(e => e.Date)
                .HasColumnType("smalldatetime")
                .HasColumnName("date");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("deliveryAddress");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.ExpressCenterId)
                .HasMaxLength(50)
                .HasColumnName("ExpressCenterID");
            entity.Property(e => e.FullName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fullName");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IgiNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("igi_no");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ModelId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("modelID");
            entity.Property(e => e.Qty)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("qty");
            entity.Property(e => e.ReceiverContant).HasMaxLength(200);
            entity.Property(e => e.ReceiverName).HasMaxLength(200);
            entity.Property(e => e.VitalityNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("vitality_no");
        });

        modelBuilder.Entity<ChildItem>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.ChItem });

            entity.ToTable("CHILD_ITEM");

            entity.HasIndex(e => e.ChItem, "nci_wi_CHILD_ITEM_93C2ADECD64C790407658D2F0209A526").HasFillFactor(80);

            entity.HasIndex(e => new { e.Item, e.Status }, "nci_wi_CHILD_ITEM_C3D4F838EB450E43DF32E2487F8A14F7").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM_FULL_NAME");
            entity.Property(e => e.ChItemShortName)
                .HasMaxLength(50)
                .HasColumnName("CH_ITEM_SHORT_NAME");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");

            entity.HasOne(d => d.MasterItem1).WithMany(p => p.ChildItems)
                .HasForeignKey(d => new { d.Company, d.Item })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTER_CHILD");
        });

        modelBuilder.Entity<ChildItem1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHILD_ITEM$");

            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_FULL_NAME");
            entity.Property(e => e.ChItemShortName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_SHORT_NAME");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost).HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade).HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost).HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade).HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Company1);

            entity.ToTable("COMPANY");

            entity.Property(e => e.Company1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Application)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APPLICATION");
            entity.Property(e => e.Area).HasColumnName("AREA");
            entity.Property(e => e.City).HasColumnName("CITY");
            entity.Property(e => e.CnicNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CNIC_NO");
            entity.Property(e => e.Country).HasColumnName("COUNTRY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Ldesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LDESC");
            entity.Property(e => e.OwnerName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OWNER_NAME");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO");
            entity.Property(e => e.Province).HasColumnName("PROVINCE");
            entity.Property(e => e.Sdesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDESC");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<ContactU>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("contact_us");

            entity.Property(e => e.DateEntry).HasColumnName("Date_entry");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subject");
        });

        modelBuilder.Entity<CorporateAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CORPORATE_ADDRESS");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.AreaId).HasColumnName("Area_ID");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("01")
                .HasColumnName("COMPANY");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_on");
            entity.Property(e => e.GpsCoordinates)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GPS_COORDINATES");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Modified_By");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("Modified_On");
            entity.Property(e => e.OrgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrgID");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Organization_Name");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CourierAccountDetail>(entity =>
        {
            entity.HasKey(e => e.CourierAccountId);

            entity.ToTable("COURIER_ACCOUNT_DETAILS");

            entity.Property(e => e.CourierAccountId).HasColumnName("COURIER_ACCOUNT_ID");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_NO");
            entity.Property(e => e.AccountPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_PASSWORD");
            entity.Property(e => e.AccountProfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_PROFILE_NAME");
            entity.Property(e => e.AccountSellerCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_SELLER_CODE");
            entity.Property(e => e.AccountUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_USERNAME");
        });

        modelBuilder.Entity<CourierBookingDetail>(entity =>
        {
            entity.HasKey(e => e.MplBookingId);

            entity.ToTable("COURIER_BOOKING_DETAILS");

            entity.Property(e => e.MplBookingId).HasColumnName("MPL_BOOKING_ID");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedOn)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_ON");
            entity.Property(e => e.BookingStatus)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BOOKING_STATUS");
            entity.Property(e => e.Codamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CODAMOUNT");
            entity.Property(e => e.Consigneeaddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONSIGNEEADDRESS");
            entity.Property(e => e.Consigneemobno)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONSIGNEEMOBNO");
            entity.Property(e => e.Consigneename)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONSIGNEENAME");
            entity.Property(e => e.ConsignmentNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONSIGNMENT_NO");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Destinationcity)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESTINATIONCITY");
            entity.Property(e => e.LoadsheetMessage)
                .HasMaxLength(500)
                .HasColumnName("LOADSHEET_MESSAGE");
            entity.Property(e => e.LoadsheetNo)
                .HasMaxLength(500)
                .HasColumnName("LOADSHEET_NO");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.OriginLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORIGIN_LOCATION");
            entity.Property(e => e.Pieces).HasColumnName("PIECES");
            entity.Property(e => e.Productdetails)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PRODUCTDETAILS");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<CourierLocationMapping>(entity =>
        {
            entity.HasKey(e => e.CourierMapId);

            entity.ToTable("COURIER_LOCATION_MAPPING");

            entity.Property(e => e.CourierMapId).HasColumnName("COURIER_MAP_ID");
            entity.Property(e => e.CourierAccountId).HasColumnName("COURIER_ACCOUNT_ID");
            entity.Property(e => e.CourierLocationAddress).HasColumnName("COURIER_LOCATION_ADDRESS");
            entity.Property(e => e.CourierLocationId).HasColumnName("COURIER_LOCATION_ID");
            entity.Property(e => e.CourierLocationName).HasColumnName("COURIER_LOCATION_NAME");
        });

        modelBuilder.Entity<CourierService>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.CourierId });

            entity.ToTable("COURIER_SERVICE");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CourierId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COURIER_ID");
            entity.Property(e => e.CourierDesc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COURIER_DESC");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<CpCustomerCatAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_CUSTOMER_CAT_ASSIGN");

            entity.Property(e => e.CategoryId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("01")
                .HasColumnName("COMPANY");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateEntry)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasColumnType("smalldatetime")
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.SellerId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.SellerLocation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SELLER_LOCATION");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<CpCustomerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_CUSTOMER_INFO");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_LINE_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_LINE_2");
            entity.Property(e => e.AreaId).HasColumnName("Area_ID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AREA_NAME");
            entity.Property(e => e.CategoryId)
                .IsUnicode(false)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY_NAME");
            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Country)
                .HasMaxLength(99)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.DslExpiry).HasColumnName("DSL_EXPIRY");
            entity.Property(e => e.DslNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DSL_NO");
            entity.Property(e => e.DslType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DSL_TYPE");
            entity.Property(e => e.EmailId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EMAIL_ID");
            entity.Property(e => e.HashExpiry)
                .HasColumnType("datetime")
                .HasColumnName("HASH_EXPIRY");
            entity.Property(e => e.HashKey)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HASH_KEY");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.LandLineNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LAND_LINE_NO");
            entity.Property(e => e.Ntn)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.Owner)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OWNER");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PoliceStation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POLICE_STATION");
            entity.Property(e => e.PostCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POST_CODE");
            entity.Property(e => e.PrimaryMobileNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PRIMARY_MOBILE_NO");
            entity.Property(e => e.Province)
                .HasMaxLength(99)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.RefCustCode1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REF_CUST_CODE_1");
            entity.Property(e => e.RefCustCode2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REF_CUST_CODE_2");
            entity.Property(e => e.RegistrationDate).HasColumnName("REGISTRATION_DATE");
            entity.Property(e => e.SecondaryMobileNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SECONDARY_MOBILE_NO");
            entity.Property(e => e.SellerId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.SellerLocation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SELLER_LOCATION");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Strn)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STRN");
            entity.Property(e => e.Tehsil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEHSIL");
            entity.Property(e => e.Town)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TOWN");
            entity.Property(e => e.TownId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TOWN_ID");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<CpCustomerOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_CUSTOMER_ORDER");

            entity.Property(e => e.Cnic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.Comments)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.CustomerAddress)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ADDRESS");
            entity.Property(e => e.CustomerName)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.Customercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUSTOMERCODE");
            entity.Property(e => e.DelvDate).HasColumnName("DELV_DATE");
            entity.Property(e => e.Depot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPOT");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.DocDate).HasColumnName("DOC_DATE");
            entity.Property(e => e.DocNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOC_NO");
            entity.Property(e => e.Document)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DOCUMENT");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("GST");
            entity.Property(e => e.Locality)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LOCALITY");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("NET_AMOUNT");
            entity.Property(e => e.Ntn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.Pop)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("POP");
            entity.Property(e => e.RefDocNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF_DOC_NO");
            entity.Property(e => e.RefDocument)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REF_DOCUMENT");
            entity.Property(e => e.RefSubDocument)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REF_SUB_DOCUMENT");
            entity.Property(e => e.SellerCustCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SELLER_CUST_CODE");
            entity.Property(e => e.SellerId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.Slocality)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SLOCALITY");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Strn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STRN");
            entity.Property(e => e.SubDocument)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SUB_DOCUMENT");
            entity.Property(e => e.Town)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TOWN");
        });

        modelBuilder.Entity<CpCustomerOrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_CUSTOMER_ORDER_DETAIL");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Batch)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATCH");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Depot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPOT");
            entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
            entity.Property(e => e.DocDate).HasColumnName("DOC_DATE");
            entity.Property(e => e.DocNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOC_NO");
            entity.Property(e => e.Document)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DOCUMENT");
            entity.Property(e => e.Gst).HasColumnName("GST");
            entity.Property(e => e.OrderQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ORDER_QTY");
            entity.Property(e => e.Otax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OTAX");
            entity.Property(e => e.PriceStruc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_STRUC");
            entity.Property(e => e.Product)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PRODUCT");
            entity.Property(e => e.ProductDesc)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_DESC");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Rate).HasColumnName("RATE");
            entity.Property(e => e.RefType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REF_TYPE");
            entity.Property(e => e.SubDocument)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SUB_DOCUMENT");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSE");
        });

        modelBuilder.Entity<CpImage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_IMAGES");

            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.Tag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TAG");
        });

        modelBuilder.Entity<CpNotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_Notification");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DateEntry).HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify).HasColumnName("DATE_MODIFY");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("End_date");
            entity.Property(e => e.FiredOn).HasColumnName("Fired_on");
            entity.Property(e => e.NotifyId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Notify_Id");
            entity.Property(e => e.NotifyImage).HasColumnName("Notify_Image");
            entity.Property(e => e.NotifyTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Notify_Title");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<CpOrderHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_Order_History");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Customer_id");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("Date_Entry");
            entity.Property(e => e.OrderDate).HasColumnName("Order_Date");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Order_No");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Entry");
        });

        modelBuilder.Entity<CpProductInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_PRODUCT_INFO");

            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BRAND");
            entity.Property(e => e.BrandId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BRAND_ID");
            entity.Property(e => e.CartonSize).HasColumnName("CARTON_SIZE");
            entity.Property(e => e.CategoryDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CATEGORY_DESC");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("01")
                .HasColumnName("COMPANY");
            entity.Property(e => e.Cost).HasColumnName("COST");
            entity.Property(e => e.DateEntry)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify).HasColumnName("DATE_MODIFY");
            entity.Property(e => e.Division)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIVISION");
            entity.Property(e => e.DivisionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIVISION_ID");
            entity.Property(e => e.Height).HasColumnName("HEIGHT");
            entity.Property(e => e.Length).HasColumnName("LENGTH");
            entity.Property(e => e.LongDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LONG_DESC");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.ManufacturerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURER_ID");
            entity.Property(e => e.Mrp).HasColumnName("MRP");
            entity.Property(e => e.Product)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRODUCT");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellerId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SHORT_DESC");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TaxPer).HasColumnName("TAX_PER");
            entity.Property(e => e.TaxType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAX_TYPE");
            entity.Property(e => e.Trade).HasColumnName("TRADE");
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            entity.Property(e => e.Width).HasColumnName("WIDTH");
        });

        modelBuilder.Entity<CpSellerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_SELLER_INFO");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_LINE_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_LINE_2");
            entity.Property(e => e.AreaId).HasColumnName("Area_ID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AREA_NAME");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY_NAME");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.ContactPersonCnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PERSON_CNIC");
            entity.Property(e => e.ContactPersonDesignation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PERSON_DESIGNATION");
            entity.Property(e => e.ContactPersonName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PERSON_NAME");
            entity.Property(e => e.Country)
                .HasMaxLength(99)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.Email1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EMAIL_1");
            entity.Property(e => e.Email2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EMAIL_2");
            entity.Property(e => e.FaxNo1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FAX_NO_1");
            entity.Property(e => e.FaxNo2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FAX_NO_2");
            entity.Property(e => e.Logo).HasColumnName("LOGO");
            entity.Property(e => e.MobileNo1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MOBILE_NO_1");
            entity.Property(e => e.MobileNo2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MOBILE_NO_2");
            entity.Property(e => e.Ntn)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.PhoneNo1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO_1");
            entity.Property(e => e.PhoneNo2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO_2");
            entity.Property(e => e.PoliceStation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POLICE_STATION");
            entity.Property(e => e.PostCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POST_CODE");
            entity.Property(e => e.Province)
                .HasMaxLength(99)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.SellerId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.SellerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SELLER_NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Strn)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("STRN");
            entity.Property(e => e.Tehsil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEHSIL");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
            entity.Property(e => e.Zone)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ZONE");
        });

        modelBuilder.Entity<CpSellerLcatAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_SELLER_LCAT_ASSIGN");

            entity.Property(e => e.CategoryId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.SellerId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.SellerLocation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELLER_LOCATION");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<CpVersion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cp_VERSION");

            entity.Property(e => e.AppVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APP_VERSION");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DateEntry).HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify).HasColumnName("DATE_MODIFY");
            entity.Property(e => e.ForcedUpdates)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FORCED_UPDATES");
            entity.Property(e => e.ServiceVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICE_VERSION");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<CustomerAssignedService>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Customer_assigned_services");

            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
        });

        modelBuilder.Entity<CustomerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Customer_Info");

            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(500)
                .IsFixedLength()
                .HasColumnName("Customer_Address");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.CustomeriD).ValueGeneratedOnAdd();
            entity.Property(e => e.MplAccountNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MPL_AccountNO");
            entity.Property(e => e.MplClientId).HasColumnName("MPL_CLientID");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUSTOMER_ORDER");

            entity.Property(e => e.Cnic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.Comments)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.CustomerAddress)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ADDRESS");
            entity.Property(e => e.CustomerName)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.Customercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUSTOMERCODE");
            entity.Property(e => e.DelvDate).HasColumnName("DELV_DATE");
            entity.Property(e => e.Depot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPOT");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.DocDate).HasColumnName("DOC_DATE");
            entity.Property(e => e.DocNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOC_NO");
            entity.Property(e => e.Document)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DOCUMENT");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("GST");
            entity.Property(e => e.Locality)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LOCALITY");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("NET_AMOUNT");
            entity.Property(e => e.Ntn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.Pop)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("POP");
            entity.Property(e => e.RefDocNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF_DOC_NO");
            entity.Property(e => e.RefDocument)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REF_DOCUMENT");
            entity.Property(e => e.RefSubDocument)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REF_SUB_DOCUMENT");
            entity.Property(e => e.Slocality)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SLOCALITY");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Strn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STRN");
            entity.Property(e => e.SubDocument)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SUB_DOCUMENT");
            entity.Property(e => e.Town)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TOWN");
        });

        modelBuilder.Entity<CustomerOrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUSTOMER_ORDER_DETAIL");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Batch)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATCH");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Depot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPOT");
            entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
            entity.Property(e => e.DocDate).HasColumnName("DOC_DATE");
            entity.Property(e => e.DocNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOC_NO");
            entity.Property(e => e.Document)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DOCUMENT");
            entity.Property(e => e.Gst).HasColumnName("GST");
            entity.Property(e => e.OrderQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ORDER_QTY");
            entity.Property(e => e.Otax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OTAX");
            entity.Property(e => e.PriceStruc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_STRUC");
            entity.Property(e => e.Product)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PRODUCT");
            entity.Property(e => e.ProductDesc)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_DESC");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Rate).HasColumnName("RATE");
            entity.Property(e => e.RefType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REF_TYPE");
            entity.Property(e => e.SubDocument)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SUB_DOCUMENT");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSE");
        });

        modelBuilder.Entity<DeliveryChargesMatrix>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Delivery_ChargesMatrix");

            entity.Property(e => e.AddressType).HasColumnName("Address_Type");
            entity.Property(e => e.City)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.DeliveryCharges).HasDefaultValue(0.0);
            entity.Property(e => e.DeliveryType)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FromAmount).HasDefaultValue(0.0);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PickUpPointId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PickUpPointID");
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.ToAmount).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<DeliveryMode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Delivery_Mode");

            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.DeliveryMode1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.DeliveryModeDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE_DESC");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DestinationCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Destination_City");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("iD");
        });

        modelBuilder.Entity<DiscountPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Discount__3214EC2702804D24");

            entity.ToTable("Discount_Price");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.OldPrice).HasColumnName("oldPrice");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("('1')")
                .HasColumnName("STATUS");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DummyScheduler>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dummy_Scheduler");

            entity.Property(e => e.DummyText).HasColumnType("datetime");
        });

        modelBuilder.Entity<DvchargesCriterion>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.DvMasterid, e.ChargesId, e.Criteria });

            entity.ToTable("DVCHARGES_CRITERIA");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DvMasterid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DV_MASTERID");
            entity.Property(e => e.ChargesId).HasColumnName("CHARGES_ID");
            entity.Property(e => e.Criteria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CRITERIA");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.CriteriaIn)
                .IsUnicode(false)
                .HasColumnName("CRITERIA_IN");
            entity.Property(e => e.CriteriaOut)
                .IsUnicode(false)
                .HasColumnName("CRITERIA_OUT");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");

            entity.HasOne(d => d.DvchargesSetup).WithMany(p => p.DvchargesCriteria)
                .HasForeignKey(d => new { d.Company, d.DvMasterid, d.ChargesId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DVCHARGES_CRT");
        });

        modelBuilder.Entity<DvchargesMaster>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.DvMasterid });

            entity.ToTable("DVCHARGES_MASTER");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DvMasterid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DV_MASTERID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Ldescription)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("LDESCRIPTION");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Sdescription)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SDESCRIPTION");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<DvchargesSetup>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.DvMasterid, e.ChargesId });

            entity.ToTable("DVCHARGES_SETUP");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DvMasterid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DV_MASTERID");
            entity.Property(e => e.ChargesId).HasColumnName("CHARGES_ID");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Claimable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CLAIMABLE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.Ldesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LDESC");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.ProjectId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PROJECT_ID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SCHEME_ID");
            entity.Property(e => e.Sdesc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SDESC");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.DvchargesMaster).WithMany(p => p.DvchargesSetups)
                .HasForeignKey(d => new { d.Company, d.DvMasterid })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DVCHARGES_SET");
        });

        modelBuilder.Entity<DvchargesSlab>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.DvMasterid, e.ChargesId, e.SlabId });

            entity.ToTable("DVCHARGES_SLABS");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DvMasterid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DV_MASTERID");
            entity.Property(e => e.ChargesId).HasColumnName("CHARGES_ID");
            entity.Property(e => e.SlabId).HasColumnName("SLAB_ID");
            entity.Property(e => e.ApptakDvcharges).HasColumnName("APPTAK_DVCHARGES");
            entity.Property(e => e.CrFrom).HasColumnName("CR_FROM");
            entity.Property(e => e.CrTo).HasColumnName("CR_TO");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Divider).HasColumnName("DIVIDER");
            entity.Property(e => e.Ldesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LDESC");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.NextDvcharges).HasColumnName("NEXT_DVCHARGES");
            entity.Property(e => e.PurchaseLimit).HasColumnName("PURCHASE_LIMIT");
            entity.Property(e => e.Sdesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SDESC");

            entity.HasOne(d => d.DvchargesMaster).WithMany(p => p.DvchargesSlabs)
                .HasForeignKey(d => new { d.Company, d.DvMasterid })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DVCHARGES_SLB");

            entity.HasOne(d => d.DvchargesSetup).WithMany(p => p.DvchargesSlabs)
                .HasForeignKey(d => new { d.Company, d.DvMasterid, d.ChargesId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DVCHARGES_SLB2");
        });

        modelBuilder.Entity<ErrorLogApi>(entity =>
        {
            entity.HasKey(e => e.ErrorId).HasName("PK__ErrorLog__358565CAEF6AC0F6");

            entity.ToTable("ErrorLog_API");

            entity.Property(e => e.ErrorId).HasColumnName("ErrorID");
            entity.Property(e => e.ErrorTime).HasColumnType("datetime");
            entity.Property(e => e.Method).HasMaxLength(100);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Query).HasMaxLength(4000);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<HitCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hit_count");

            entity.Property(e => e.BrandCode).HasColumnName("Brand_CODE");
            entity.Property(e => e.CategoryCode).HasColumnName("Category_CODE");
            entity.Property(e => e.CompanyCode).HasColumnName("COMPANY_CODE");
            entity.Property(e => e.EntryDate).HasColumnName("Entry_date");
            entity.Property(e => e.ModelCode).HasColumnName("Model_CODE");
            entity.Property(e => e.SubCategoryCode).HasColumnName("SubCategory_CODE");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.ToTable("invoices");

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.DocumentCategory).HasMaxLength(1);
            entity.Property(e => e.FocconsumeQuantity).HasColumnName("FOCConsumeQuantity");
            entity.Property(e => e.FocconsumeQuantity1).HasColumnName("FOCConsumeQuantity1");
            entity.Property(e => e.FoccountAgainstIbreeze).HasColumnName("FOCCountAgainstIbreeze");
            entity.Property(e => e.FoccountAgainstPurchase).HasColumnName("FOCCountAgainstPurchase");
            entity.Property(e => e.Focquantity).HasColumnName("FOCQuantity");
            entity.Property(e => e.Focquantity1).HasColumnName("FOCQuantity1");
            entity.Property(e => e.InvoiceNumber).HasDefaultValue("");
            entity.Property(e => e.PatientCnic).HasColumnName("PatientCNIC");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PfizerWyethInvoiceNo).HasColumnName("Pfizer_WyethInvoiceNo");
            entity.Property(e => e.UploadPdf).HasColumnName("UploadPDF");
        });

        modelBuilder.Entity<IshoppingOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IShopping_Order");

            entity.Property(e => e.AccountId)
                .HasMaxLength(30)
                .HasColumnName("AccountID");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Area_Name");
            entity.Property(e => e.BillName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Cnic)
                .HasMaxLength(30)
                .HasColumnName("CNIC");
            entity.Property(e => e.Codamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CODAmount");
            entity.Property(e => e.CodreferenceNo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CODReferenceNO");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Createdby).HasMaxLength(40);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.DeliveryCharges)
                .HasMaxLength(30)
                .HasColumnName("Delivery_Charges");
            entity.Property(e => e.GrossTotal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Gross_Total");
            entity.Property(e => e.Isprocessed)
                .HasDefaultValueSql("('0')")
                .HasColumnName("ISPROCESSED");
            entity.Property(e => e.ItemDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Item_Detail");
            entity.Property(e => e.OType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("01")
                .HasColumnName("O_Type");
            entity.Property(e => e.OrderId)
                .HasMaxLength(40)
                .HasColumnName("OrderID");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProdId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prod_ID");
            entity.Property(e => e.Purchaseon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Quantity)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.ShipName)
                .HasMaxLength(50)
                .HasColumnName("shipName");
            entity.Property(e => e.ShippingCity).HasMaxLength(50);
            entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ItemBundle>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.ChItem, e.SmItem, e.SerialNo });

            entity.ToTable("ITEM_BUNDLE");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.SmItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SM_ITEM");
            entity.Property(e => e.SerialNo).HasColumnName("SERIAL_NO");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Qty).HasColumnName("QTY");
            entity.Property(e => e.SmRate)
                .HasColumnType("decimal(13, 4)")
                .HasColumnName("SM_RATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");

            entity.HasOne(d => d.ChildItem).WithMany(p => p.ItemBundles)
                .HasForeignKey(d => new { d.Company, d.ChItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CH_ITEM_BUNDLE");

            entity.HasOne(d => d.MasterItem1).WithMany(p => p.ItemBundles)
                .HasForeignKey(d => new { d.Company, d.Item })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTER_BUNDLE");
        });

        modelBuilder.Entity<ItemCapping>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.CapId });

            entity.ToTable("ITEM_CAPPING");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CapId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CAP_ID");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("DATE_END");
            entity.Property(e => e.DateStart)
                .HasColumnType("datetime")
                .HasColumnName("DATE_START");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<ItemCategory>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Item, e.ScatCode });

            entity.ToTable("ITEM_CATEGORY");

            entity.HasIndex(e => new { e.Company, e.ScatCode, e.Status }, "nci_wi_ITEM_CATEGORY_5B6A2C915681828941480FD22CBE719F").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");

            entity.HasOne(d => d.MasterItem1).WithMany(p => p.ItemCategories)
                .HasForeignKey(d => new { d.Company, d.Item })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ITEM_CAT_MASTER");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.ItemCategories)
                .HasForeignKey(d => new { d.Company, d.ScatCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ITEM_CAT");
        });

        modelBuilder.Entity<ItemCategory1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ITEM_CATEGORY$");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(255)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<ItemDescription>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Item, e.DescLabel }).HasName("PK_ITEM_DESC");

            entity.ToTable("ITEM_DESCRIPTION");

            entity.HasIndex(e => e.Item, "nci_wi_ITEM_DESCRIPTION_6EA3A0E699E5FFD7186451EBD736A3B3").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.DescLabel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESC_LABEL");
            entity.Property(e => e.DescDetail)
                .IsUnicode(false)
                .HasColumnName("DESC_DETAIL");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");

            entity.HasOne(d => d.MasterItem1).WithMany(p => p.ItemDescriptions)
                .HasForeignKey(d => new { d.Company, d.Item })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTER_DESC");
        });

        modelBuilder.Entity<ItemDiscount>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.ChItem });

            entity.ToTable("ITEM_DISCOUNT");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.DiscCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DISC_CODE");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0L)
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");

            entity.HasOne(d => d.ChildItem).WithOne(p => p.ItemDiscount)
                .HasForeignKey<ItemDiscount>(d => new { d.Company, d.ChItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CH_ITEM_DISCOUNT");

            entity.HasOne(d => d.MasterItem1).WithMany(p => p.ItemDiscounts)
                .HasForeignKey(d => new { d.Company, d.Item })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTER_DISCOUNT");
        });

        modelBuilder.Entity<ItemFulfill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Item_Fulfill");

            entity.ToTable("ITEM_FULFILL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DivisionCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIVISION_CODE");
            entity.Property(e => e.Fulfillby)
                .IsUnicode(false)
                .HasColumnName("FULFILLBY");
            entity.Property(e => e.Logo).HasColumnName("LOGO");
            entity.Property(e => e.PrincipalCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRINCIPAL_CODE");
            entity.Property(e => e.Supportby)
                .IsUnicode(false)
                .HasColumnName("SUPPORTBY");
            entity.Property(e => e.WarrantyText)
                .IsUnicode(false)
                .HasColumnName("WARRANTY_TEXT");
        });

        modelBuilder.Entity<ItemGeneric>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("item_generic$");

            entity.Property(e => e.Generics).HasMaxLength(255);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(255)
                .HasColumnName("Item_Code ");
        });

        modelBuilder.Entity<ItemImagesLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ITEM_IMAGES_LINKS");

            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.RefId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REF_ID");
            entity.Property(e => e.RefLink).HasColumnName("REF_LINK");
            entity.Property(e => e.RefType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("REF_TYPE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Tag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
        });

        modelBuilder.Entity<ItemLogo>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Criteria, e.CriteriaIn });

            entity.ToTable("ITEM_LOGOS");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Criteria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CRITERIA");
            entity.Property(e => e.CriteriaIn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRITERIA_IN");
            entity.Property(e => e.DateEntry)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.ImagePath)
                .IsUnicode(false)
                .HasColumnName("IMAGE_PATH");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<ItemStock>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.ChItem }).HasName("PK_STOCK_ITEM");

            entity.ToTable("ITEM_STOCK");

            entity.HasIndex(e => new { e.Item, e.Company }, "nci_wi_ITEM_STOCK_6CA38DFEBC86FB36DB4C19F4A8008F02").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Stock).HasColumnName("STOCK");
            entity.Property(e => e.StockType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STOCK_TYPE");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSE");

            entity.HasOne(d => d.ChildItem).WithOne(p => p.ItemStock)
                .HasForeignKey<ItemStock>(d => new { d.Company, d.ChItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CH_ITEM_STOCK");

            entity.HasOne(d => d.MasterItem1).WithMany(p => p.ItemStocks)
                .HasForeignKey(d => new { d.Company, d.Item })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTER_STOCK");
        });

        modelBuilder.Entity<ItemStockLocation>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.PickupPointId, e.CityId, e.ChItem, e.Seller }).HasName("PK_STOCK_ITEM_LOC");

            entity.ToTable("ITEM_STOCK_LOCATION");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.PickupPointId).HasColumnName("PickupPoint_ID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Seller)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SELLER");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Stock).HasColumnName("STOCK");
            entity.Property(e => e.StockType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STOCK_TYPE");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSE");

            entity.HasOne(d => d.MasterItem1).WithMany(p => p.ItemStockLocations)
                .HasForeignKey(d => new { d.Company, d.Item })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTER_STOCK_LOC");
        });

        modelBuilder.Entity<ItemStockLog>(entity =>
        {
            entity.HasKey(e => e.TrId);

            entity.ToTable("ITEM_STOCK_LOG");

            entity.Property(e => e.TrId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TR_ID");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.RefDocNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_DOC_NO");
            entity.Property(e => e.Stock).HasColumnName("STOCK");
        });

        modelBuilder.Entity<ItemType>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Item });

            entity.ToTable("ITEM_TYPE");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.ItemType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM_TYPE");
            entity.Property(e => e.ItemTypeId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ITEM_TYPE_ID");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");

            entity.HasOne(d => d.MasterItem1).WithOne(p => p.ItemType)
                .HasForeignKey<ItemType>(d => new { d.Company, d.Item })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTER_ITYPE");
        });

        modelBuilder.Entity<LeverageSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LEVERAGE_SALES");

            entity.Property(e => e.Acgrp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ACGRP");
            entity.Property(e => e.Areatype)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("AREATYPE");
            entity.Property(e => e.Batch)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BATCH");
            entity.Property(e => e.Batch2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BATCH2");
            entity.Property(e => e.Bonus)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BONUS");
            entity.Property(e => e.BonusAmt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BONUS_AMT");
            entity.Property(e => e.CashmemoType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CASHMEMO_TYPE");
            entity.Property(e => e.Cminv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMINV");
            entity.Property(e => e.ContractNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CONTRACT_NO");
            entity.Property(e => e.Cpclass)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CPCLASS");
            entity.Property(e => e.Cust)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CUST");
            entity.Property(e => e.Daymon).HasColumnName("DAYMON");
            entity.Property(e => e.Dbdate).HasColumnName("DBDATE");
            entity.Property(e => e.Depot)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEPOT");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISC");
            entity.Property(e => e.Discpunit).HasColumnName("DISCPUNIT");
            entity.Property(e => e.Dlman)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DLMAN");
            entity.Property(e => e.FlagBookby)
                .IsUnicode(false)
                .HasColumnName("FLAG_BOOKBY");
            entity.Property(e => e.Gramt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("GRAMT");
            entity.Property(e => e.Grpo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("GRPO");
            entity.Property(e => e.Hcclass)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("HCCLASS");
            entity.Property(e => e.Letter)
                .IsUnicode(false)
                .HasColumnName("LETTER");
            entity.Property(e => e.Locality)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LOCALITY");
            entity.Property(e => e.Ltrdat)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LTRDAT");
            entity.Property(e => e.Mrpval)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MRPVAL");
            entity.Property(e => e.Ntown)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("NTOWN");
            entity.Property(e => e.OrderBooker)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ORDER_BOOKER");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.Phclass)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PHCLASS");
            entity.Property(e => e.Pickno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PICKNO");
            entity.Property(e => e.Pkstkt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PKSTKT");
            entity.Property(e => e.Pkstot)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PKSTOT");
            entity.Property(e => e.Pkstrn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PKSTRN");
            entity.Property(e => e.Pop)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POP");
            entity.Property(e => e.Prdcd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRDCD");
            entity.Property(e => e.Qnty)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("QNTY");
            entity.Property(e => e.Ratepunit).HasColumnName("RATEPUNIT");
            entity.Property(e => e.Reason)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.Reccd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RECCD");
            entity.Property(e => e.Section)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SECTION");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Slocality)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SLOCALITY");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Stax)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("STAX");
            entity.Property(e => e.Taxpunit).HasColumnName("TAXPUNIT");
            entity.Property(e => e.Town)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TOWN");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<MajorCategory>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.McatCode, e.MjcatCode });

            entity.ToTable("MAJOR_CATEGORY");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.McatCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MCAT_CODE");
            entity.Property(e => e.MjcatCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MJCAT_CODE");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.MjcatImage).HasColumnName("MJCAT_IMAGE");
            entity.Property(e => e.MjcatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MJCAT_NAME");
            entity.Property(e => e.MjcatThumb).HasColumnName("MJCAT_THUMB");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Sno).HasColumnName("SNO");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");

            entity.HasOne(d => d.MasterCategory).WithMany(p => p.MajorCategories)
                .HasForeignKey(d => new { d.Company, d.McatCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTER_MJCAT");
        });

        modelBuilder.Entity<MasterCategory>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.McatCode });

            entity.ToTable("MASTER_CATEGORY");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.McatCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MCAT_CODE");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.McatImage).HasColumnName("MCAT_IMAGE");
            entity.Property(e => e.McatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MCAT_NAME");
            entity.Property(e => e.McatThumb).HasColumnName("MCAT_THUMB");
            entity.Property(e => e.MenuTheme).HasColumnName("MENU_THEME");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Sno).HasColumnName("SNO");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<MasterDdList>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Description, e.DdKey, e.DdValue });

            entity.ToTable("MASTER_DD_LIST");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.DdKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DD_KEY");
            entity.Property(e => e.DdValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DD_VALUE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DdStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DD_STATUS");
            entity.Property(e => e.DdText)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DD_TEXT");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
        });

        modelBuilder.Entity<MasterItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'Master Item$'");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Delivery)
                .HasMaxLength(255)
                .HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("IMAGE");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(255)
                .HasColumnName("Item Full_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.MasterCode)
                .HasMaxLength(255)
                .HasColumnName("Master Code");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost).HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade).HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost).HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade).HasColumnName("OLD_TRADE");
            entity.Property(e => e.Prescription).HasColumnName("PRESCRIPTION");
            entity.Property(e => e.Prod1)
                .HasMaxLength(255)
                .HasColumnName("PROD1");
            entity.Property(e => e.Prod1Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD1_DESC");
            entity.Property(e => e.Prod2)
                .HasMaxLength(255)
                .HasColumnName("PROD2");
            entity.Property(e => e.Prod2Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD2_DESC");
            entity.Property(e => e.Prod3)
                .HasMaxLength(255)
                .HasColumnName("PROD3");
            entity.Property(e => e.Prod3Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD3_DESC");
            entity.Property(e => e.Prod4)
                .HasMaxLength(255)
                .HasColumnName("PROD4");
            entity.Property(e => e.Prod4Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD4_DESC");
            entity.Property(e => e.Prod5)
                .HasMaxLength(255)
                .HasColumnName("PROD5");
            entity.Property(e => e.Prod5Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD5_DESC");
            entity.Property(e => e.Prod6)
                .HasMaxLength(255)
                .HasColumnName("PROD6");
            entity.Property(e => e.Prod6Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD6_DESC");
            entity.Property(e => e.Prod7)
                .HasMaxLength(255)
                .HasColumnName("PROD7");
            entity.Property(e => e.Prod7Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD7_DESC");
            entity.Property(e => e.Prod8)
                .HasMaxLength(255)
                .HasColumnName("PROD8");
            entity.Property(e => e.Prod8Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD8_DESC");
            entity.Property(e => e.Prod9)
                .HasMaxLength(255)
                .HasColumnName("PROD9");
            entity.Property(e => e.Prod9Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD9_DESC");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(255)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Seller)
                .HasMaxLength(255)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<MasterItem1>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Item });

            entity.ToTable("MASTER_ITEM");

            entity.HasIndex(e => new { e.Status, e.SellCategory }, "nci_wi_MASTER_ITEM_08B0C84A88D11C8C6CCAEE7100AE1CC6").HasFillFactor(80);

            entity.HasIndex(e => new { e.Status, e.Company, e.NewMrsp }, "nci_wi_MASTER_ITEM_0D8BD52DA47C5F23B304EA47F0AE8293").HasFillFactor(80);

            entity.HasIndex(e => new { e.Item1, e.Status }, "nci_wi_MASTER_ITEM_40F9AAD071D0BCF60616471E61D96726");

            entity.HasIndex(e => new { e.Item, e.Status }, "nci_wi_MASTER_ITEM_44181D74175D64ACB00C1ACCCA60FF95").HasFillFactor(80);

            entity.HasIndex(e => new { e.Company, e.Status, e.Item1 }, "nci_wi_MASTER_ITEM_50CAD451F1D8DEDC69812F44D3462ECB");

            entity.HasIndex(e => new { e.Company, e.Status }, "nci_wi_MASTER_ITEM_6FCA77F55228BB7072D605546095774E");

            entity.HasIndex(e => new { e.Status, e.Company }, "nci_wi_MASTER_ITEM_ADB5F0A89D2350C5F99D578E1622E724").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Delivery)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.ImageUrl).HasColumnName("IMAGE_URL");
            entity.Property(e => e.Item1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item1Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM1_NAME");
            entity.Property(e => e.Item2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM2");
            entity.Property(e => e.Item2Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM2_NAME");
            entity.Property(e => e.Item3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM3");
            entity.Property(e => e.Item3Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM3_NAME");
            entity.Property(e => e.Item4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM4");
            entity.Property(e => e.Item4Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM4_NAME");
            entity.Property(e => e.Item5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM5");
            entity.Property(e => e.Item5Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM5_NAME");
            entity.Property(e => e.Item6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM6");
            entity.Property(e => e.Item6Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM6_NAME");
            entity.Property(e => e.Item7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM7");
            entity.Property(e => e.Item7Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM7_NAME");
            entity.Property(e => e.Item8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM8");
            entity.Property(e => e.Item8Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM8_NAME");
            entity.Property(e => e.Item9)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM9");
            entity.Property(e => e.Item9Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM9_NAME");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ITEM_FULL_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.Prescription).HasColumnName("PRESCRIPTION");
            entity.Property(e => e.Productlink)
                .IsUnicode(false)
                .HasColumnName("PRODUCTLINK");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Seller)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<MasterItem2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("master_item$");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Delivery)
                .HasMaxLength(255)
                .HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("IMAGE");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .HasColumnName("IMAGE_URL");
            entity.Property(e => e.Item).HasColumnName("ITEM");
            entity.Property(e => e.Item1)
                .HasMaxLength(255)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item1Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM1_NAME");
            entity.Property(e => e.Item2).HasColumnName("ITEM2");
            entity.Property(e => e.Item2Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM2_NAME");
            entity.Property(e => e.Item3)
                .HasMaxLength(255)
                .HasColumnName("ITEM3");
            entity.Property(e => e.Item3Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM3_NAME");
            entity.Property(e => e.Item4)
                .HasMaxLength(255)
                .HasColumnName("ITEM4");
            entity.Property(e => e.Item4Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM4_NAME");
            entity.Property(e => e.Item5)
                .HasMaxLength(255)
                .HasColumnName("ITEM5");
            entity.Property(e => e.Item5Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM5_NAME");
            entity.Property(e => e.Item6)
                .HasMaxLength(255)
                .HasColumnName("ITEM6");
            entity.Property(e => e.Item6Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM6_NAME");
            entity.Property(e => e.Item7)
                .HasMaxLength(255)
                .HasColumnName("ITEM7");
            entity.Property(e => e.Item7Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM7_NAME");
            entity.Property(e => e.Item8)
                .HasMaxLength(255)
                .HasColumnName("ITEM8");
            entity.Property(e => e.Item8Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM8_NAME");
            entity.Property(e => e.Item9)
                .HasMaxLength(255)
                .HasColumnName("ITEM9");
            entity.Property(e => e.Item9Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM9_NAME");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_FULL_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost).HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade).HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost).HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade).HasColumnName("OLD_TRADE");
            entity.Property(e => e.Prescription).HasColumnName("PRESCRIPTION");
            entity.Property(e => e.Productlink)
                .HasMaxLength(255)
                .HasColumnName("PRODUCTLINK");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(255)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Seller)
                .HasMaxLength(255)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<MasterItemDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MASTER_ITEM_DETAIL");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Length)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("length");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ProductDescription)
                .IsUnicode(false)
                .HasColumnName("Product_Description");
            entity.Property(e => e.ProductHighlights)
                .IsUnicode(false)
                .HasColumnName("Product_Highlights");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
            entity.Property(e => e.WarrantyPeriod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Warranty_Period");
            entity.Property(e => e.WarrantyPolicy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Warranty_Policy");
            entity.Property(e => e.WarrantyType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Warranty_Type");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WhatsInTheBox)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Whats_in_the_box");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<MasterOrder>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.MasterorderId });

            entity.ToTable("MASTER_ORDER");

            entity.HasIndex(e => e.PaymentMode, "nci_wi_MASTER_ORDER_05B4D009AF05E00B74AEE510EAD4ECB0");

            entity.HasIndex(e => e.DsrCode, "nci_wi_MASTER_ORDER_65894C3F20490F6BD8A28B5E46117E0E");

            entity.HasIndex(e => new { e.OrderRefNo, e.Createdby }, "nci_wi_MASTER_ORDER_76C5FEA24618F9A18A0F9BD354F59FD0").HasFillFactor(80);

            entity.HasIndex(e => new { e.MasterorderId, e.Status }, "nci_wi_MASTER_ORDER_7A864D84AB13CAA95AD6ABE014049340").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.MasterorderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.AddressType)
                .HasDefaultValue(4)
                .HasColumnName("ADDRESS_TYPE");
            entity.Property(e => e.Adiscount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.BankCharges)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BANK_CHARGES");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.DsrCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("dsr_code");
            entity.Property(e => e.FedCharges)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FED_CHARGES");
            entity.Property(e => e.MasterorderDate).HasColumnName("MASTERORDER_DATE");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(40)
                .HasColumnName("Order_RefNo");
            entity.Property(e => e.OrderType)
                .HasDefaultValue(1)
                .HasColumnName("ORDER_TYPE");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.Promo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PROMO");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<MasterOrderLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MASTER_ORDER_log");

            entity.Property(e => e.AddressType).HasColumnName("address_type");
            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.BankCharges)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("BANK_CHARGES");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.DsrCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("dsr_code");
            entity.Property(e => e.FedCharges)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("FED_CHARGES");
            entity.Property(e => e.MasterorderDate).HasColumnName("MASTERORDER_DATE");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderRefno)
                .HasMaxLength(40)
                .HasColumnName("Order_refno");
            entity.Property(e => e.OrderType).HasColumnName("ORDER_TYPE");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.Promo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PROMO");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Menu");

            entity.Property(e => e.CategoryCode).HasColumnName("Category_CODE");
            entity.Property(e => e.CompanyCode).HasColumnName("Company_CODE");
            entity.Property(e => e.ParentCode).HasColumnName("Parent_CODE");
            entity.Property(e => e.ParentName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Parent_Name");
            entity.Property(e => e.Status1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status1");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MenuAssignedMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MENU_ASSIGNED_MENUS");

            entity.Property(e => e.ChildId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("child_id");
            entity.Property(e => e.ParentId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("parent_id");
            entity.Property(e => e.RCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("r_code");
            entity.Property(e => e.SubchildId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("subchild_id");
            entity.Property(e => e.UserType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("user_type");
        });

        modelBuilder.Entity<MenuChild>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MENU_CHILD");

            entity.Property(e => e.ChildDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("child_desc");
            entity.Property(e => e.ChildId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("child_id");
            entity.Property(e => e.ChildUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("child_url");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MenuIconClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("menu_icon_class");
            entity.Property(e => e.ParentId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("parent_id");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.UrlStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("url_status");
        });

        modelBuilder.Entity<MenuChildTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("menu_child_test");

            entity.Property(e => e.ChildDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("child_desc");
            entity.Property(e => e.ChildId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("child_id");
            entity.Property(e => e.ChildUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("child_url");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MenuIconClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("menu_icon_class");
            entity.Property(e => e.ParentId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("parent_id");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.UrlStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("url_status");
        });

        modelBuilder.Entity<MenuParent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MENU_PARENT");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MenuIconClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Menu_icon_class");
            entity.Property(e => e.ParentDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parent_desc");
            entity.Property(e => e.ParentId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("parent_url");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.UrlStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("url_status");
        });

        modelBuilder.Entity<MenuParentTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("menu_parent_test");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MenuIconClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Menu_icon_class");
            entity.Property(e => e.ParentDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parent_desc");
            entity.Property(e => e.ParentId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("parent_url");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.UrlStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("url_status");
        });

        modelBuilder.Entity<MenuSubchild>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MENU_SUBCHILD");

            entity.Property(e => e.ChildId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("child_id");
            entity.Property(e => e.MenuIconClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("menu_icon_class");
            entity.Property(e => e.ParentId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("parent_id");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubchildDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Subchild_desc");
            entity.Property(e => e.SubchildId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Subchild_id");
            entity.Property(e => e.SubchildUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Subchild_url");
        });

        modelBuilder.Entity<MnpLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Mnp_location");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<MobileAppInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Mobile_App_info");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ThemeColor1)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Theme_Color_1");
            entity.Property(e => e.ThemeColor2)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Theme_Color_2");
            entity.Property(e => e.ThemeColor3)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Theme_Color_3");
            entity.Property(e => e.ThemeColor4)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Theme_Color_4");
        });

        modelBuilder.Entity<ModelReview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Model_Reviews");

            entity.Property(e => e.BrandCode).HasColumnName("Brand_CODE");
            entity.Property(e => e.CategoryCode).HasColumnName("Category_CODE");
            entity.Property(e => e.Comments)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CompanyCode).HasColumnName("COMPANY_CODE");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Model_CODE");
            entity.Property(e => e.Nickname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quality)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Reviews)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SubCategoryCode).HasColumnName("SubCategory_CODE");
            entity.Property(e => e.SummaryReviews)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Summary_Reviews");
        });

        modelBuilder.Entity<ModelSpecification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Model_Specification");

            entity.Property(e => e.BatteryStandBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BATTERY_Stand_by");
            entity.Property(e => e.BatteryTalkTime)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BATTERY_Talk_time");
            entity.Property(e => e.BatteryType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BATTERY_Type");
            entity.Property(e => e.BodyDimensions)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BODY_Dimensions");
            entity.Property(e => e.BodyDualSim)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BODY_dual_sim");
            entity.Property(e => e.BodySim)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BODY_sim");
            entity.Property(e => e.BodyWeight)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BODY_Weight");
            entity.Property(e => e.BrandCode).HasColumnName("Brand_CODE");
            entity.Property(e => e.CategoryCode).HasColumnName("Category_CODE");
            entity.Property(e => e.CommsBluetooth)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMS_Bluetooth");
            entity.Property(e => e.CommsGps)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMS_GPS");
            entity.Property(e => e.CommsInfraredPort)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMS_Infrared_port");
            entity.Property(e => e.CommsNfc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMS_NFC");
            entity.Property(e => e.CommsRadio)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMS_Radio");
            entity.Property(e => e.CommsUsb)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMS_USB");
            entity.Property(e => e.CommsWlan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMS_WLAN");
            entity.Property(e => e.CompanyCode).HasColumnName("COMPANY_CODE");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.DateModify).HasColumnName("Date_Modify");
            entity.Property(e => e.DisplayMultitouch)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DISPLAY_Multitouch");
            entity.Property(e => e.DisplayResolution)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DISPLAY_Resolution");
            entity.Property(e => e.DisplaySize)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DISPLAY_Size");
            entity.Property(e => e.DisplayType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DISPLAY_Type");
            entity.Property(e => e.FeaturesBrowser)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FEATURES_Browser");
            entity.Property(e => e.FeaturesJava)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FEATURES_Java");
            entity.Property(e => e.FeaturesMessaging)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FEATURES_Messaging");
            entity.Property(e => e.FeaturesOthers)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FEATURES_Others");
            entity.Property(e => e.FeaturesSensors)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FEATURES_Sensors");
            entity.Property(e => e.LaunchAnnounced)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LAUNCH_Announced");
            entity.Property(e => e.LaunchStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LAUNCH_Status");
            entity.Property(e => e.MainCameraFeatures)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAIN|CAMERA_Features");
            entity.Property(e => e.MainCameraModules)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAIN|CAMERA_Modules");
            entity.Property(e => e.MainCameraVideo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAIN|CAMERA_Video");
            entity.Property(e => e.MemoryCardSlot)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MEMORY_Card_slot");
            entity.Property(e => e.MemoryInternal)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MEMORY_Internal");
            entity.Property(e => e.MiscColor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MISC_color");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Model_CODE");
            entity.Property(e => e.NetworkG2Bands)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NETWORK_G2_bands");
            entity.Property(e => e.NetworkG3Bands)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NETWORK_G3_bands");
            entity.Property(e => e.NetworkG4Bands)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NETWORK_G4_bands");
            entity.Property(e => e.NetworkG5Bands)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NETWORK_G5_bands");
            entity.Property(e => e.NetworkTechnology)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NETWORK_Technology");
            entity.Property(e => e.PlatformChipset)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLATFORM_Chipset");
            entity.Property(e => e.PlatformCpu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLATFORM_CPU");
            entity.Property(e => e.PlatformGpu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLATFORM_GPU");
            entity.Property(e => e.PlatformOs)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLATFORM_OS");
            entity.Property(e => e.SelfieCameraFeatures)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SELFIE|CAMERA_Features");
            entity.Property(e => e.SelfieCameraModules)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SELFIE|CAMERA_Modules");
            entity.Property(e => e.SelfieCameraVideo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SELFIE|CAMERA_Video");
            entity.Property(e => e.SoundAlertTypes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOUND_Alert_types");
            entity.Property(e => e.SoundLoudspeaker)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOUND_Loudspeaker");
            entity.Property(e => e.SoundMmjack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOUND_mmjack");
            entity.Property(e => e.SoundOthers)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOUND_others");
            entity.Property(e => e.SubCategoryCode).HasColumnName("SubCategory_CODE");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Entry");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<MplBookingDetail>(entity =>
        {
            entity.HasKey(e => e.MplBookingId);

            entity.ToTable("MPL_BOOKING_DETAILS");

            entity.Property(e => e.MplBookingId).HasColumnName("MPL_BOOKING_ID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedOn)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_ON");
            entity.Property(e => e.BookingStatus)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BOOKING_STATUS");
            entity.Property(e => e.Codamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CODAMOUNT");
            entity.Property(e => e.Consigneeaddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONSIGNEEADDRESS");
            entity.Property(e => e.Consigneemobno)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONSIGNEEMOBNO");
            entity.Property(e => e.Consigneename)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONSIGNEENAME");
            entity.Property(e => e.ConsignmentNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONSIGNMENT_NO");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Destinationcity)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESTINATIONCITY");
            entity.Property(e => e.LoadsheetMessage)
                .HasMaxLength(500)
                .HasColumnName("LOADSHEET_MESSAGE");
            entity.Property(e => e.LoadsheetNo)
                .HasMaxLength(500)
                .HasColumnName("LOADSHEET_NO");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.OriginLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORIGIN_LOCATION");
            entity.Property(e => e.Pieces).HasColumnName("PIECES");
            entity.Property(e => e.Productdetails)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PRODUCTDETAILS");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<Newsletter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Newsletter");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
        });

        modelBuilder.Entity<ORiderBooking>(entity =>
        {
            entity.HasKey(e => e.MasterorderId).HasName("PK_RIDER_BOOKING");

            entity.ToTable("o_RIDER_BOOKING");

            entity.Property(e => e.MasterorderId)
                .ValueGeneratedNever()
                .HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.OrderDeliveryDate).HasColumnName("ORDER_DELIVERY_DATE");
            entity.Property(e => e.OrderPickupDate).HasColumnName("ORDER_PICKUP_DATE");
            entity.Property(e => e.UserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USER_ID");
        });

        modelBuilder.Entity<ORiderBookingTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("o_RIDER_BOOKING_TEMP");

            entity.Property(e => e.BookingDate).HasColumnName("BOOKING_DATE");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DeliveredImage).HasColumnName("DELIVERED_IMAGE");
            entity.Property(e => e.DeliveryDate).HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.PickupDate).HasColumnName("PICKUP_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USER_ID");
        });

        modelBuilder.Entity<ORiderOrderTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("o_RIDER_ORDER_TRACKING");

            entity.Property(e => e.Cordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CORDINATES");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.TrackDate)
                .HasColumnType("datetime")
                .HasColumnName("TRACK_DATE");
            entity.Property(e => e.Userid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USERID");
        });

        modelBuilder.Entity<ORiderPreferedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("o_RIDER_PREFERED_AREA");

            entity.Property(e => e.AreaId).HasColumnName("AREA_ID");
            entity.Property(e => e.CityId).HasColumnName("CITY_ID");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.Userid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USERID");
        });

        modelBuilder.Entity<OrderAttribute>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("order_attributes");

            entity.HasIndex(e => new { e.AttributeName, e.OrderId }, "nci_wi_order_attributes_C4972A2D946512248FCEF969A56FE147");

            entity.Property(e => e.AttributeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attribute_name");
            entity.Property(e => e.AttributeValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attribute_value");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
        });

        modelBuilder.Entity<OrderDelivery>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.MasterorderId });

            entity.ToTable("ORDER_DELIVERY");

            entity.HasIndex(e => e.MasterorderId, "nci_wi_ORDER_DELIVERY_4655791610756E28665E7A724FE801E8").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.ConsignmentNo)
                .HasMaxLength(50)
                .HasColumnName("CONSIGNMENT_NO");
            entity.Property(e => e.CourierService)
                .HasMaxLength(50)
                .HasColumnName("COURIER_SERVICE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DeliveredBy)
                .HasMaxLength(50)
                .HasColumnName("DELIVERED_BY");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("receiver_name");
            entity.Property(e => e.ReceiverRelation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("receiver_relation");

            entity.HasOne(d => d.MasterOrder).WithOne(p => p.OrderDelivery)
                .HasForeignKey<OrderDelivery>(d => new { d.Company, d.MasterorderId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORD_DELV_MASTERORDER");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Depotcode, e.OrderId, e.ChItem, e.Item });

            entity.ToTable("ORDER_DETAIL");

            entity.HasIndex(e => new { e.OrderId, e.Company }, "nci_wi_ORDER_DETAIL_20198A5909FF8D9FDF70EE7E1C979441").HasFillFactor(80);

            entity.HasIndex(e => e.Quantity, "nci_wi_ORDER_DETAIL_3C457EE1D6CD157F92D3759F0F641145");

            entity.HasIndex(e => new { e.Company, e.Item }, "nci_wi_ORDER_DETAIL_DCB625A73E5F988276E85F8BE429A865").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Adiscount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.MrspNew)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MRSP_NEW");
            entity.Property(e => e.MrspOld)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MRSP_OLD");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NEW_COST");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");
            entity.Property(e => e.PrecriptionImg).HasColumnName("PRECRIPTION_IMG");
            entity.Property(e => e.PriceTag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("B")
                .HasColumnName("PRICE_TAG");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELL_CATEGORY");

            entity.HasOne(d => d.OrderHead).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => new { d.Company, d.Depotcode, d.OrderId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OD_OH");
        });

        modelBuilder.Entity<OrderDetailApptak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Order_Detail_Apptak");

            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADiscount1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADiscount2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADiscount3");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .HasColumnName("ch_Item");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Company_Code");
            entity.Property(e => e.Createdby)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Item).HasMaxLength(20);
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Modifiedon).HasColumnType("datetime");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NetAMount");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("Order_Date");
            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Order_id");
            entity.Property(e => e.Quantity).HasMaxLength(10);
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .HasColumnName("Sell_Category");
        });

        modelBuilder.Entity<OrderDetailBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Order_Detail_BACKUP");

            entity.Property(e => e.BrandCode).HasColumnName("Brand_CODE");
            entity.Property(e => e.CategoryCode).HasColumnName("Category_CODE");
            entity.Property(e => e.CompanyCode).HasColumnName("COMPANY_CODE");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Model_CODE");
            entity.Property(e => e.ModelPrice).HasColumnName("Model_PRICE");
            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SubCategoryCode).HasColumnName("SubCategory_CODE");
            entity.Property(e => e.UserCode)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USER_CODE");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Entry");
        });

        modelBuilder.Entity<OrderDetailLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORDER_DETAIL_LOG");

            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(15)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.MrspNew)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("Mrsp_New");
            entity.Property(e => e.MrspOld)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("Mrsp_old");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_COST");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.PrescriptionImg).HasColumnName("Prescription_img");
            entity.Property(e => e.PriceTag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("B")
                .HasColumnName("PRICE_TAG");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELL_CATEGORY");
        });

        modelBuilder.Entity<OrderDvchargesDetail>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Depotcode, e.OrderId, e.ChItem, e.Item, e.DvMasterid, e.ChargesId });

            entity.ToTable("ORDER_DVCHARGES_DETAIL");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.DvMasterid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DV_MASTERID");
            entity.Property(e => e.ChargesId).HasColumnName("CHARGES_ID");
            entity.Property(e => e.ApptakCharges).HasColumnName("APPTAK_CHARGES");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("smalldatetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("smalldatetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.NextCharges).HasColumnName("NEXT_CHARGES");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");

            entity.HasOne(d => d.OrderHead).WithMany(p => p.OrderDvchargesDetails)
                .HasForeignKey(d => new { d.Company, d.Depotcode, d.OrderId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OD_ODV");
        });

        modelBuilder.Entity<OrderHead>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Depotcode, e.OrderId });

            entity.ToTable("ORDER_HEAD");

            entity.HasIndex(e => e.DelvDate, "IX_OrderHead_DelvDate");

            entity.HasIndex(e => new { e.OrderStatus, e.Createdby, e.OrderDate }, "idx_comp_1");

            entity.HasIndex(e => new { e.OrderStatus, e.Createdby }, "nci_msft_1_ORDER_HEAD_18C271EF2DBB5AC7DC2F240669BD4692");

            entity.HasIndex(e => new { e.OrderStatus, e.DelvDate }, "nci_wi_ORDER_HEAD_3F1A1DBC8BE0D68E54D639EEA20EA7C5");

            entity.HasIndex(e => e.OrderId, "nci_wi_ORDER_HEAD_6C6F5BE8AA3C7ABA6716475499F333DA").HasFillFactor(80);

            entity.HasIndex(e => new { e.OrderStatus, e.Depotcode }, "nci_wi_ORDER_HEAD_819A74301F71819EF5C220A4A7BC0AEF").HasFillFactor(80);

            entity.HasIndex(e => new { e.MasterorderId, e.Company, e.OrderStatus }, "nci_wi_ORDER_HEAD_B671253FB9C90BC0F6EE714A7C6B4B64").HasFillFactor(80);

            entity.HasIndex(e => e.Depotcode, "nci_wi_ORDER_HEAD_CDE1387720C5715B57D79012A0C8AFC7").HasFillFactor(80);

            entity.HasIndex(e => new { e.Createdby, e.OrderStatus }, "nci_wi_ORDER_HEAD_E6019132D19C64F9254025F29515CBB2");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.Adiscount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.DelvDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("DELV_DATE");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ORDER_STATUS");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.PharmaApproved)
                .HasDefaultValue(false)
                .HasColumnName("PHARMA_APPROVED");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
            entity.Property(e => e.SzInvoice)
                .IsUnicode(false)
                .HasColumnName("SZ_INVOICE");
            entity.Property(e => e.SzInvoiceValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SZ_INVOICE_VALUE");
            entity.Property(e => e.TotalPackets)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("TOTAL_PACKETS");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSE");
        });

        modelBuilder.Entity<OrderHeadApptak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Order_Head_Apptak");

            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADiscount1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADiscount2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADiscount3");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Company_Code");
            entity.Property(e => e.Createdby).HasMaxLength(20);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.DeliveryCharges).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .HasColumnName("Delivery_Mode");
            entity.Property(e => e.Depotcode).HasMaxLength(10);
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MobileNo).HasMaxLength(15);
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Modifiedon).HasColumnType("datetime");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NetAMount");
            entity.Property(e => e.OrderDate).HasColumnName("Order_Date");
            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Order_id");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(2)
                .HasColumnName("Order_Status");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .HasColumnName("Payment_Mode");
            entity.Property(e => e.SAddress1)
                .HasMaxLength(100)
                .HasColumnName("S_Address1");
            entity.Property(e => e.SAddress2)
                .HasMaxLength(100)
                .HasColumnName("S_Address2");
            entity.Property(e => e.SArea)
                .HasMaxLength(3)
                .HasColumnName("S_Area");
            entity.Property(e => e.SCity)
                .HasMaxLength(3)
                .HasColumnName("S_City");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .HasColumnName("S_Country");
            entity.Property(e => e.SFullName)
                .HasMaxLength(100)
                .HasColumnName("S_FullName");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .HasColumnName("S_Province");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .HasColumnName("S_Zipcode");
        });

        modelBuilder.Entity<OrderHeadBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Order_head_BACKUP");

            entity.Property(e => e.CompanyCode).HasColumnName("COMPANY_CODE");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.OrderId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.SpecialRequests)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("special_requests");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UserCode)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USER_CODE");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Entry");
        });

        modelBuilder.Entity<OrderHeadLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORDER_HEAD_Log");

            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.DelvDate).HasColumnName("DELV_DATE");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(50)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ORDER_STATUS");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.PharmaApproved)
                .HasDefaultValue(false)
                .HasColumnName("PHARMA_APPROVED");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
            entity.Property(e => e.SzInvoice)
                .IsUnicode(false)
                .HasColumnName("SZ_INVOICE");
            entity.Property(e => e.SzInvoiceValue)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("SZ_INVOICE_VALUE");
            entity.Property(e => e.TotalPackets)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("TOTAL_PACKETS");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSE");
        });

        modelBuilder.Entity<OrderPrescription>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Depotcode, e.OrderId, e.ChItem, e.Item }).HasName("PK_ORDERP_DETAIL");

            entity.ToTable("ORDER_PRESCRIPTION");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.CancelReason)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("N/A")
                .HasColumnName("CANCEL_REASON");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DoctorContactNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOCTOR_CONTACT_NO");
            entity.Property(e => e.DoctorName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOCTOR_NAME");
            entity.Property(e => e.Ispdf).HasColumnName("ISPDF");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.PrecriptionImg).HasColumnName("PRECRIPTION_IMG");
            entity.Property(e => e.PrescriptionDate).HasColumnName("PRESCRIPTION_DATE");
        });

        modelBuilder.Entity<OrderReturned>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.MasterorderId });

            entity.ToTable("ORDER_RETURNED");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.ConsignmentNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Consignment_No");
            entity.Property(e => e.CourierService)
                .HasMaxLength(50)
                .HasColumnName("COURIER_SERVICE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.ReasonCode).HasColumnName("REASON_CODE");
            entity.Property(e => e.ReturnedBy)
                .HasMaxLength(50)
                .HasColumnName("RETURNED_BY");
        });

        modelBuilder.Entity<OrderShipment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("order_shipment");

            entity.Property(e => e.BillToAddress1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BILL_TO_address_1");
            entity.Property(e => e.BillToAddress2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BILL_TO_address_2");
            entity.Property(e => e.BillToArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BILL_TO_Area");
            entity.Property(e => e.BillToCity)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BILL_TO_City");
            entity.Property(e => e.BillToCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BILL_TO_Country");
            entity.Property(e => e.BillToFirstName)
                .HasMaxLength(30)
                .HasColumnName("BILL_TO_First_Name");
            entity.Property(e => e.BillToPhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BILL_TO_Phone_No");
            entity.Property(e => e.BillToPostalCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BILL_TO_Postal_Code");
            entity.Property(e => e.BillToProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BILL_TO_Province");
            entity.Property(e => e.OrderId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Payment_Method");
            entity.Property(e => e.ShipToAddress1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_address_1");
            entity.Property(e => e.ShipToAddress2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_address_2");
            entity.Property(e => e.ShipToArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_Area");
            entity.Property(e => e.ShipToCity)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_City");
            entity.Property(e => e.ShipToCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_Country");
            entity.Property(e => e.ShipToFirstName)
                .HasMaxLength(30)
                .HasColumnName("SHIP_TO_First_Name");
            entity.Property(e => e.ShipToPhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_Phone_No");
            entity.Property(e => e.ShipToPostalCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_Postal_Code");
            entity.Property(e => e.ShipToProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_Province");
            entity.Property(e => e.ShipmentMethod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Shipment_Method");
            entity.Property(e => e.UserCode)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USER_CODE");
        });

        modelBuilder.Entity<OrderStationary>(entity =>
        {
            entity.ToTable("ORDER_STATIONARY");

            entity.Property(e => e.OrderStationaryId).HasColumnName("ORDER_STATIONARY_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.StationaryId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATIONARY_ID");
        });

        modelBuilder.Entity<OrderStationaryLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORDER_STATIONARY_LOG");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.StationaryId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATIONARY_ID");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Id });

            entity.ToTable("ORDER_STATUS");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<OrderStatusBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Order_Status_BACKUP");

            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Orderstatus)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderTrackingLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("order_tracking_log");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("created_on");
            entity.Property(e => e.NewStatus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("New_status");
            entity.Property(e => e.OldStatus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Old_status");
            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Order_ID");
        });

        modelBuilder.Entity<OriginCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Origin_City");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("iD");
        });

        modelBuilder.Entity<PaymentGateway>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.PgId });

            entity.ToTable("PAYMENT_GATEWAY");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.PgId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PG_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Fed)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("FED");
            entity.Property(e => e.LogoUrl).HasColumnName("LOGO_URL");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("smalldatetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.PgDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PG_DESC");
            entity.Property(e => e.ServiceCharges)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("SERVICE_CHARGES");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<PaymentMode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payment_Mode");

            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentMode1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.PaymentModeDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE_DESC");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PaymentTransResponse>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Transactionid });

            entity.ToTable("PAYMENT_TRANS_RESPONSE");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("01")
                .HasColumnName("COMPANY");
            entity.Property(e => e.Transactionid)
                .ValueGeneratedOnAdd()
                .HasColumnName("TRANSACTIONID");
            entity.Property(e => e.PgId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PG_ID");
            entity.Property(e => e.PpAmount)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_AMOUNT");
            entity.Property(e => e.PpAuthcode)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_AUTHCODE");
            entity.Property(e => e.PpBankid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_BANKID");
            entity.Property(e => e.PpBillreference)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_BILLREFERENCE");
            entity.Property(e => e.PpLanguage)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_LANGUAGE");
            entity.Property(e => e.PpMerchantid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_MERCHANTID");
            entity.Property(e => e.PpResponsecode)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_RESPONSECODE");
            entity.Property(e => e.PpResponsemessage)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_RESPONSEMESSAGE");
            entity.Property(e => e.PpRetreivalreferenceno)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_RETREIVALREFERENCENO");
            entity.Property(e => e.PpSecurehash)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_SECUREHASH");
            entity.Property(e => e.PpSettlementexpiry)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_SETTLEMENTEXPIRY");
            entity.Property(e => e.PpSubmerchantid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_SUBMERCHANTID");
            entity.Property(e => e.PpTxncurrency)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_TXNCURRENCY");
            entity.Property(e => e.PpTxndatetime)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_TXNDATETIME");
            entity.Property(e => e.PpTxnrefno)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_TXNREFNO");
            entity.Property(e => e.PpTxntype)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_TXNTYPE");
            entity.Property(e => e.PpVersion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PP_VERSION");
            entity.Property(e => e.Ppmbf1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMBF_1");
            entity.Property(e => e.Ppmbf2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMBF_2");
            entity.Property(e => e.Ppmbf3)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMBF_3");
            entity.Property(e => e.Ppmbf4)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMBF_4");
            entity.Property(e => e.Ppmbf5)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMBF_5");
            entity.Property(e => e.Ppmpf1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMPF_1");
            entity.Property(e => e.Ppmpf2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMPF_2");
            entity.Property(e => e.Ppmpf3)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMPF_3");
            entity.Property(e => e.Ppmpf4)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMPF_4");
            entity.Property(e => e.Ppmpf5)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PPMPF_5");
        });

        modelBuilder.Entity<PfzHcplist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pfz_hcplist");

            entity.Property(e => e.CreatedDate)
                .HasMaxLength(255)
                .HasColumnName("created_date");
            entity.Property(e => e.DoctorId)
                .HasMaxLength(255)
                .HasColumnName("DoctorID");
            entity.Property(e => e.DoctorName).HasMaxLength(255);
            entity.Property(e => e.HcpType)
                .HasMaxLength(255)
                .HasColumnName("hcp_type");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(255)
                .HasColumnName("updated_date");
        });

        modelBuilder.Entity<PfzItemMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pfz_item_map");

            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("ch_item");
            entity.Property(e => e.InstallmentItem)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ItemType)
                .HasMaxLength(255)
                .HasColumnName("item_type");
            entity.Property(e => e.PackSize)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProductDetail).HasMaxLength(255);
            entity.Property(e => e.ProductId)
                .HasMaxLength(255)
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductStrength).HasMaxLength(255);
        });

        modelBuilder.Entity<PharmaCancelReason>(entity =>
        {
            entity.ToTable("PHARMA_CANCEL_REASON");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DisplayText)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISPLAY_TEXT");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<PrepaidBillReference>(entity =>
        {
            entity.ToTable("PREPAID_BILL_REFERENCE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MasterorderIdList).HasColumnName("MASTERORDER_ID_LIST");
            entity.Property(e => e.PgId)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("PG_ID");
            entity.Property(e => e.PrepaidBillReference1)
                .HasMaxLength(100)
                .HasColumnName("PREPAID_BILL_REFERENCE");
        });

        modelBuilder.Entity<PriceFilter>(entity =>
        {
            entity.ToTable("PRICE_FILTER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.McatCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MCAT_CODE");
            entity.Property(e => e.MjcatCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MJCAT_CODE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.Ordernumber).HasColumnName("ORDERNUMBER");
            entity.Property(e => e.PriceMax).HasColumnName("PRICE_MAX");
            entity.Property(e => e.PriceMin).HasColumnName("PRICE_MIN");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Text)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEXT");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<ProductPromotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product___3213E83F30F910A5");

            entity.ToTable("Product_Promotions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FreeUnits).HasMaxLength(15);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PromotionId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PromotionID");
            entity.Property(e => e.PromotionProductcode).HasMaxLength(15);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.Units).HasMaxLength(15);
        });

        modelBuilder.Entity<PromoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROMO_DETAILS");

            entity.Property(e => e.Capping).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ChItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ch_Item");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.PromotionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PromotionType)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PromotionValue).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProvincialTaxationScheme>(entity =>
        {
            entity.ToTable("PROVINCIAL_TAXATION_SCHEME");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProvinceId).HasColumnName("PROVINCE_ID");
            entity.Property(e => e.StRate)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("ST_RATE");
            entity.Property(e => e.WithholdingRate)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("WITHHOLDING_RATE");
        });

        modelBuilder.Entity<PspAuditApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PSP_AUDIT_API");

            entity.Property(e => e.AccessDate)
                .HasColumnType("datetime")
                .HasColumnName("ACCESS_DATE");
            entity.Property(e => e.ActionName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTION_NAME");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.MethodName)
                .IsUnicode(false)
                .HasColumnName("METHOD_NAME");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.ResponseData)
                .IsUnicode(false)
                .HasColumnName("RESPONSE_DATA");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<PspCancellationReason>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PSP_CANCELLATION_REASONS");

            entity.Property(e => e.Description)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ReconcilliationTable>(entity =>
        {
            entity.HasKey(e => e.ReconId);

            entity.ToTable("RECONCILLIATION_TABLE");

            entity.Property(e => e.ReconId).HasColumnName("RECON_ID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.MasterorderId)
                .HasMaxLength(50)
                .HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.SalezmanInvoice).HasColumnName("SALEZMAN_INVOICE");
            entity.Property(e => e.SalezmanValue)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SALEZMAN_VALUE");
        });

        modelBuilder.Entity<RiderAppDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rider_app_documents");

            entity.Property(e => e.DocumentTypeDesc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("document_type_desc");
            entity.Property(e => e.DocumentTypeId)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("document_type_id");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<RiderBooking>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.UserId, e.MasterorderId }).HasName("PK_NRIDER_BOOKING");

            entity.ToTable("RIDER_BOOKING");

            entity.HasIndex(e => new { e.UserId, e.DeliveryDate }, "nci_wi_RIDER_BOOKING_CF09277D28472C5A36425CF56F2031F3");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.UserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USER_ID");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.BookedGps)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOKED_GPS");
            entity.Property(e => e.BookingDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING_DATE");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DeliverGps)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DELIVER_GPS");
            entity.Property(e => e.DeliveredImage).HasColumnName("DELIVERED_IMAGE");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.PickupDate)
                .HasColumnType("datetime")
                .HasColumnName("PICKUP_DATE");
            entity.Property(e => e.PickupGps)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PICKUP_GPS");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<RiderOrderTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RIDER_ORDER_TRACKING");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Coordinates)
                .IsUnicode(false)
                .HasColumnName("COORDINATES");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.TrackDate)
                .HasColumnType("datetime")
                .HasColumnName("TRACK_DATE");
            entity.Property(e => e.UserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USER_ID");

            entity.HasOne(d => d.RiderBooking).WithMany()
                .HasForeignKey(d => new { d.Company, d.UserId, d.MasterorderId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RBT_RB");
        });

        modelBuilder.Entity<RiderPreferedArea>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.UserId, e.CountryId, e.ProvinceId, e.CityId, e.AreaId });

            entity.ToTable("RIDER_PREFERED_AREA");

            entity.HasIndex(e => new { e.AreaId, e.CityId, e.CountryId, e.ProvinceId, e.Status, e.UserId }, "nci_wi_RIDER_PREFERED_AREA_FF9FA2656983CB935C855F9A7035B833").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.UserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("USER_ID");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.AreaId).HasColumnName("Area_ID");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<RiderProgess>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.Activity, e.CreatedBy }).HasName("PK__RIDER_PR__237595A1600FC249");

            entity.ToTable("RIDER_PROGESS");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Activity)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("activity");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("created_on");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<SellCategory>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.SellCategoryId }).HasName("PK_SellingCategory");

            entity.ToTable("SELL_CATEGORY");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.SellCategoryId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Sell_CategoryID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.SellCategory1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Sell_Category");
            entity.Property(e => e.Seller)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SELLER");

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.SellCategories)
                .HasForeignKey(d => d.Company)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SellingCategory_C");
        });

        modelBuilder.Entity<Seller>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Seller1 }).HasName("PK_SELLER_COMPANY");

            entity.ToTable("SELLER");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Seller1)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SELLER");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.AreaId).HasColumnName("AREA_ID");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.CnicNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CNIC_NO");
            entity.Property(e => e.CommissionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COMMISSION_TYPE");
            entity.Property(e => e.CommissionValue)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("COMMISSION_VALUE");
            entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FulfillVisibility)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FULFILL_VISIBILITY");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(400)
                .IsFixedLength()
                .HasColumnName("IMAGE_URL");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Owner)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OWNER");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.SellerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SELLER_NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.StoreType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STORE_TYPE");
            entity.Property(e => e.Visibility)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VISIBILITY");
            entity.Property(e => e.Website)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WEBSITE");

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.Sellers)
                .HasForeignKey(d => d.Company)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SC_C");

            entity.HasOne(d => d.AddArea).WithMany(p => p.Sellers)
                .HasForeignKey(d => new { d.Company, d.CountryId, d.ProvinceId, d.CityId, d.AreaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SELLER_AREA");
        });

        modelBuilder.Entity<SellerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SELLER_INFO");

            entity.Property(e => e.AccountType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_TYPE");
            entity.Property(e => e.BankAccountNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCOUNT_NO");
            entity.Property(e => e.BankAccountTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCOUNT_TITLE");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_BRANCH");
            entity.Property(e => e.BankChequePic).HasColumnName("BANK_CHEQUE_PIC");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_NAME");
            entity.Property(e => e.BusinessLocation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BUSINESS_LOCATION");
            entity.Property(e => e.BusinessNtn)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BUSINESS_NTN");
            entity.Property(e => e.BusinessReturn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BUSINESS_RETURN");
            entity.Property(e => e.BusinessStrn)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BUSINESS_STRN");
            entity.Property(e => e.BusinessWarehouse)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BUSINESS_WAREHOUSE");
            entity.Property(e => e.CnicPic1).HasColumnName("CNIC_PIC_1");
            entity.Property(e => e.CnicPic2).HasColumnName("CNIC_PIC_2");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createddby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEDDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Logo).HasColumnName("LOGO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Seller)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SELLER");
            entity.Property(e => e.SellerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SELLER_NAME");
            entity.Property(e => e.TaxPayer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TAX_PAYER");
            entity.Property(e => e.UserCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Code");
        });

        modelBuilder.Entity<SellerOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Seller_Order");

            entity.Property(e => e.AddressLabelStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AddressLabel_Status");
            entity.Property(e => e.Codamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CODAmount");
            entity.Property(e => e.CodreferenceNo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CODReferenceNO");
            entity.Property(e => e.ConsigneeAddress).HasMaxLength(500);
            entity.Property(e => e.ConsigneeEmail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ConsigneeMobileNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ConsigneeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsigneerClientId).HasColumnName("ConsigneerClientID");
            entity.Property(e => e.ConsignerAccountNo)
                .HasMaxLength(10)
                .HasColumnName("consignerAccountNo");
            entity.Property(e => e.ConsignerAddress)
                .HasMaxLength(500)
                .HasColumnName("consignerAddress");
            entity.Property(e => e.ConsignerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignerName");
            entity.Property(e => e.ConsignmentNumber)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DestinationCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("destinationCity");
            entity.Property(e => e.EntryType)
                .HasMaxLength(20)
                .HasColumnName("Entry_Type");
            entity.Property(e => e.FCentre).HasColumnName("F_centre");
            entity.Property(e => e.LoadSheetStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LoadSheet_Status");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("modifiedon");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderReference).HasMaxLength(20);
            entity.Property(e => e.OrderStatus).HasColumnName("order_Status");
            entity.Property(e => e.OriginCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("originCity");
            entity.Property(e => e.Pieces)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ProductDetail)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecialHandling)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Weight)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SellerOrderArchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Seller_Order_Archive");

            entity.Property(e => e.AddressLabelStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AddressLabel_Status");
            entity.Property(e => e.Codamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CODAmount");
            entity.Property(e => e.CodreferenceNo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CODReferenceNO");
            entity.Property(e => e.ConsigneeAddress).HasMaxLength(500);
            entity.Property(e => e.ConsigneeEmail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ConsigneeMobileNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ConsigneeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsigneerClientId).HasColumnName("ConsigneerClientID");
            entity.Property(e => e.ConsignerAccountNo)
                .HasMaxLength(10)
                .HasColumnName("consignerAccountNo");
            entity.Property(e => e.ConsignerAddress)
                .HasMaxLength(500)
                .HasColumnName("consignerAddress");
            entity.Property(e => e.ConsignerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignerName");
            entity.Property(e => e.ConsignmentNumber)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DestinationCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("destinationCity");
            entity.Property(e => e.EntryType)
                .HasMaxLength(20)
                .HasColumnName("Entry_Type");
            entity.Property(e => e.FCentre).HasColumnName("F_centre");
            entity.Property(e => e.LoadSheetStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LoadSheet_Status");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("modifiedon");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderReference).HasMaxLength(20);
            entity.Property(e => e.OrderStatus).HasColumnName("order_Status");
            entity.Property(e => e.OriginCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("originCity");
            entity.Property(e => e.Pieces)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ProductDetail)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecialHandling)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Weight)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SellerOrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Seller_Order_Detail");

            entity.Property(e => e.ActualPrice).HasColumnName("ActualPRICE");
            entity.Property(e => e.BrandCode).HasColumnName("Brand_CODE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Model_CODE");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("modifiedon");
            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Product_Name");
        });

        modelBuilder.Entity<SellerOrderDetailArchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Seller_Order_Detail_Archive");

            entity.Property(e => e.ActualPrice).HasColumnName("ActualPRICE");
            entity.Property(e => e.BrandCode).HasColumnName("Brand_CODE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Model_CODE");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("modifiedon");
            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Product_Name");
        });

        modelBuilder.Entity<SellerPaymentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SELLER_PAYMENT_DETAIL");

            entity.Property(e => e.Comments)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Commission)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("COMMISSION");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.Delivery)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DELIVERY");
            entity.Property(e => e.DocumentDate).HasColumnName("DOCUMENT_DATE");
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOCUMENT_NO");
            entity.Property(e => e.FromDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.OrderAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ORDER_AMOUNT");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ORDER_NUMBER");
            entity.Property(e => e.OtherCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("OTHER_CHARGES");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PAYMENT_AMOUNT");
            entity.Property(e => e.PaymentType).HasColumnName("payment_type");
            entity.Property(e => e.Penality)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PENALITY");
            entity.Property(e => e.Seller)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.ToDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TO_DATE");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("VAT");
        });

        modelBuilder.Entity<SellerPaymentHead>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SELLER_PAYMENT_HEAD");

            entity.Property(e => e.Comments)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.DocumentDate).HasColumnName("DOCUMENT_DATE");
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOCUMENT_NO");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NET_AMOUNT");
            entity.Property(e => e.PaymentPeriod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_PERIOD");
            entity.Property(e => e.Seller)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<SellerSetting>(entity =>
        {
            entity.ToTable("SELLER_SETTINGS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryCondition).HasColumnName("CATEGORY_CONDITION");
            entity.Property(e => e.DoorstepDisable).HasColumnName("DOORSTEP_DISABLE");
            entity.Property(e => e.PrepaidDisable).HasColumnName("PREPAID_DISABLE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(50)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.SsStatus).HasColumnName("SS_STATUS");
        });

        modelBuilder.Entity<SeoMapping>(entity =>
        {
            entity.HasKey(e => e.SeoId).HasName("PK__SEO_MAPP__A8675ADB9D2F6A5A");

            entity.ToTable("SEO_MAPPING");

            entity.Property(e => e.SeoId).HasColumnName("SEO_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Keyword)
                .IsUnicode(false)
                .HasColumnName("KEYWORD");
            entity.Property(e => e.Major)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MAJOR");
            entity.Property(e => e.Master)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MASTER");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Sub)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SUB");
        });

        modelBuilder.Entity<ServiceCenter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("serviceCenter");

            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("contactPerson");
            entity.Property(e => e.Date)
                .HasColumnType("smalldatetime")
                .HasColumnName("date");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Lat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAT");
            entity.Property(e => e.Location)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Long)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LONG");
            entity.Property(e => e.SecondContactPerson)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("secondContactPerson");
            entity.Property(e => e.ThirdContactPerson)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("thirdContactPerson");
        });

        modelBuilder.Entity<ServiceType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Service_Type");

            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ServiceTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ServiceTypeNAme");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SghConsignmentsError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_CONSIGNMENTS_ERROR");

            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Errordescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ERRORDESCRIPTION");
            entity.Property(e => e.Estoreorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTOREORDERID");
        });

        modelBuilder.Entity<SghEorderLinesStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_EORDER_LINES_STATUS");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_Description");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");
        });

        modelBuilder.Entity<SghEorderStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_EORDER_STATUS");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_Description");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");
        });

        modelBuilder.Entity<SghEorderStatusStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_EORDER_STATUS_STG");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_Description");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");
        });

        modelBuilder.Entity<SghOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS");

            entity.HasIndex(e => e.PartnerOrderId, "nci_wi_SGH_ORDERS_A4A3363B33CDEDEB9C1428407C3509FF");

            entity.HasIndex(e => e.EstoreOrderId, "nci_wi_SGH_ORDERS_B08C997431F24EA03D988E806D942215");

            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deliveryMethod");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.Destinationid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("destinationid");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.MnpStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("mnp_status");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("partnerOrderId");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReturnCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("return_code");
            entity.Property(e => e.RmsStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("rms_status");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<SghOrderBillingaddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_BILLINGADDRESS");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contactPhone");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Line1)
                .HasMaxLength(1200)
                .IsUnicode(false)
                .HasColumnName("line1");
            entity.Property(e => e.Line2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line2");
            entity.Property(e => e.Line3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line3");
            entity.Property(e => e.LocationId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locationId");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("postalCode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<SghOrderBillingaddress27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_BILLINGADDRESS_27052022");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contactPhone");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Line1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line1");
            entity.Property(e => e.Line2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line2");
            entity.Property(e => e.Line3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line3");
            entity.Property(e => e.LocationId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locationId");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("postalCode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<SghOrderBillingaddressStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_BILLINGADDRESS_STG");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contactPhone");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Line1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line1");
            entity.Property(e => e.Line2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line2");
            entity.Property(e => e.Line3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line3");
            entity.Property(e => e.LocationId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locationId");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("postalCode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<SghOrderBillingaddressTst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sgh_order_billingaddress_tst");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contactPhone");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Line1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line1");
            entity.Property(e => e.Line2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line2");
            entity.Property(e => e.Line3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line3");
            entity.Property(e => e.LocationId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locationId");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("postalCode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<SghOrderConsignment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_CONSIGNMENTS");

            entity.HasIndex(e => new { e.EstoreOrderId, e.ConsignmentId }, "nci_wi_SGH_ORDER_CONSIGNMENTS_115AD99457633D7240BB18A1BBBB0FF5");

            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("consignmentId");
            entity.Property(e => e.DiscAmount)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("discAmount");
            entity.Property(e => e.DiscRate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("discRate");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.IncFeeAmount)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("incFeeAmount");
            entity.Property(e => e.IncTaxAmount)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("incTaxAmount");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.LineItemTotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("lineItemTotal");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("quantity");
            entity.Property(e => e.RegularRetailPrice)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("regularRetailPrice");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.TaxAmount)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxRate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("taxRate");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("trackingNumber");
            entity.Property(e => e.WarehouseId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("warehouseId");
        });

        modelBuilder.Entity<SghOrderConsignments27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_CONSIGNMENTS_27052022");

            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("consignmentId");
            entity.Property(e => e.DiscAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("discAmount");
            entity.Property(e => e.DiscRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("discRate");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.IncFeeAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("incFeeAmount");
            entity.Property(e => e.IncTaxAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("incTaxAmount");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.LineItemTotal)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("lineItemTotal");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("quantity");
            entity.Property(e => e.RegularRetailPrice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("regularRetailPrice");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("taxRate");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("trackingNumber");
            entity.Property(e => e.WarehouseId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("warehouseId");
        });

        modelBuilder.Entity<SghOrderConsignmentsStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_CONSIGNMENTS_STG");

            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("consignmentId");
            entity.Property(e => e.DiscAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("discAmount");
            entity.Property(e => e.DiscRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("discRate");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.IncFeeAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("incFeeAmount");
            entity.Property(e => e.IncTaxAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("incTaxAmount");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.LineItemTotal)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("lineItemTotal");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("quantity");
            entity.Property(e => e.RegularRetailPrice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("regularRetailPrice");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("taxRate");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("trackingNumber");
            entity.Property(e => e.WarehouseId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("warehouseId");
        });

        modelBuilder.Entity<SghOrderConsignmentsTst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sgh_order_consignments_tst");

            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("consignmentId");
            entity.Property(e => e.DiscAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("discAmount");
            entity.Property(e => e.DiscRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("discRate");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.IncFeeAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("incFeeAmount");
            entity.Property(e => e.IncTaxAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("incTaxAmount");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.LineItemTotal)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("lineItemTotal");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("quantity");
            entity.Property(e => e.RegularRetailPrice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("regularRetailPrice");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("taxRate");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("trackingNumber");
            entity.Property(e => e.WarehouseId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("warehouseId");
        });

        modelBuilder.Entity<SghOrderCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_CUSTOMERS");

            entity.Property(e => e.Cnic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("customerId");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<SghOrderCustomers27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_CUSTOMERS_27052022");

            entity.Property(e => e.Cnic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("customerId");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<SghOrderCustomersStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_CUSTOMERS_STG");

            entity.Property(e => e.Cnic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("customerId");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<SghOrderCustomersTst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sgh_order_customers_tst");

            entity.Property(e => e.Cnic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("customerId");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<SghOrderDiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_DISCOUNTS");

            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.DiscountRate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discountRate");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SequenceId).HasColumnName("sequenceId");
        });

        modelBuilder.Entity<SghOrderDiscounts27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_DISCOUNTS_27052022");

            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.DiscountRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discountRate");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SequenceId).HasColumnName("sequenceId");
        });

        modelBuilder.Entity<SghOrderDiscountsStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_DISCOUNTS_STG");

            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.DiscountRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discountRate");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SequenceId).HasColumnName("sequenceId");
        });

        modelBuilder.Entity<SghOrderDiscountsTst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sgh_order_discounts_tst");

            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.DiscountRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discountRate");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SequenceId).HasColumnName("sequenceId");
        });

        modelBuilder.Entity<SghOrderPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_PAYMENTS");

            entity.Property(e => e.Amount)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("amount");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Method)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("method");
            entity.Property(e => e.PaymentResponse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("paymentResponse");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<SghOrderPaymentAddInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_PAYMENT_ADD_INFO");

            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<SghOrderPaymentAddInfo27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_PAYMENT_ADD_INFO_27052022");

            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<SghOrderPaymentAddInfoStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_PAYMENT_ADD_INFO_STG");

            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<SghOrderPayments27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_PAYMENTS_27052022");

            entity.Property(e => e.Amount)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("amount");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Method)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("method");
            entity.Property(e => e.PaymentResponse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("paymentResponse");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<SghOrderPaymentsStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_PAYMENTS_STG");

            entity.Property(e => e.Amount)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("amount");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Method)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("method");
            entity.Property(e => e.PaymentResponse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("paymentResponse");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<SghOrderShippingaddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_SHIPPINGADDRESS");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignmentId");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contactPhone");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Line1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line1");
            entity.Property(e => e.Line2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line2");
            entity.Property(e => e.Line3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line3");
            entity.Property(e => e.LocationId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locationId");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("postalCode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<SghOrderShippingaddress27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_SHIPPINGADDRESS_27052022");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignmentId");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contactPhone");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Line1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line1");
            entity.Property(e => e.Line2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line2");
            entity.Property(e => e.Line3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line3");
            entity.Property(e => e.LocationId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locationId");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("postalCode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<SghOrderShippingaddressStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_SHIPPINGADDRESS_STG");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignmentId");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contactPhone");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Line1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line1");
            entity.Property(e => e.Line2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line2");
            entity.Property(e => e.Line3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("line3");
            entity.Property(e => e.LocationId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locationId");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("postalCode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<SghOrderShippingaddressTst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sgh_order_shippingaddress_tst");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignmentId");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contactPhone");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Line1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line1");
            entity.Property(e => e.Line2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line2");
            entity.Property(e => e.Line3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line3");
            entity.Property(e => e.LocationId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locationId");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("postalCode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<SghOrderStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_STATUS");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_Description");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");
        });

        modelBuilder.Entity<SghOrderStatusStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_STATUS_STG");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_Description");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");
        });

        modelBuilder.Entity<SghOrderTaxes27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_TAXES_27052022");

            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Consignmentid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignmentid");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Rate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rate");
        });

        modelBuilder.Entity<SghOrderTaxesStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_TAXES_STG");

            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Consignmentid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignmentid");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Lineitemid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("lineitemid");
            entity.Property(e => e.Rate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rate");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
        });

        modelBuilder.Entity<SghOrderTaxesTst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sgh_order_taxes_tst");

            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Consignmentid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignmentid");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
        });

        modelBuilder.Entity<SghOrderTaxis>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDER_TAXES");

            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Consignmentid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignmentid");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Lineitemid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("lineitemid");
            entity.Property(e => e.Rate)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("rate");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
        });

        modelBuilder.Entity<SghOrders27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS_27052022");

            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deliveryMethod");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.Destinationid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("destinationid");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.MnpStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("mnp_status");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("partnerOrderId");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReturnCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("return_code");
            entity.Property(e => e.RmsStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("rms_status");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<SghOrdersArc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS_arc");

            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deliveryMethod");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.Destinationid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("destinationid");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.MnpStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("mnp_status");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("partnerOrderId");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReturnCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("return_code");
            entity.Property(e => e.RmsStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("rms_status");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<SghOrdersLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS_LOG");

            entity.Property(e => e.ActionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACTION_NAME");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.Response)
                .IsUnicode(false)
                .HasColumnName("RESPONSE");
            entity.Property(e => e.Updateon)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEON");
        });

        modelBuilder.Entity<SghOrdersLog27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS_LOG_27052022");

            entity.Property(e => e.ActionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACTION_NAME");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.OrderId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.Response)
                .IsUnicode(false)
                .HasColumnName("RESPONSE");
            entity.Property(e => e.Updateon)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEON");
        });

        modelBuilder.Entity<SghOrdersLogStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS_LOG_STG");

            entity.Property(e => e.ActionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACTION_NAME");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.Response)
                .IsUnicode(false)
                .HasColumnName("RESPONSE");
            entity.Property(e => e.Updateon)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEON");
        });

        modelBuilder.Entity<SghOrdersLogTst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sgh_orders_log_tst");

            entity.Property(e => e.ActionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACTION_NAME");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.OrderId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.Response)
                .IsUnicode(false)
                .HasColumnName("RESPONSE");
            entity.Property(e => e.Updateon)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEON");
        });

        modelBuilder.Entity<SghOrdersLogTst13052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sgh_orders_log_tst_13052022");

            entity.Property(e => e.ActionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACTION_NAME");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.OrderId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.Response)
                .IsUnicode(false)
                .HasColumnName("RESPONSE");
            entity.Property(e => e.Updateon)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEON");
        });

        modelBuilder.Entity<SghOrdersPod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS_POD");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.DeliveryDateTime)
                .HasColumnType("datetime")
                .HasColumnName("deliveryDateTime");
            entity.Property(e => e.ReceiverCnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("receiverCNIC");
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("receiverName");
        });

        modelBuilder.Entity<SghOrdersPod27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS_POD_27052022");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.DeliveryDateTime)
                .HasColumnType("datetime")
                .HasColumnName("deliveryDateTime");
            entity.Property(e => e.ReceiverCnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("receiverCNIC");
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("receiverName");
        });

        modelBuilder.Entity<SghOrdersPodStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS_POD_STG");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.DeliveryDateTime)
                .HasColumnType("datetime")
                .HasColumnName("deliveryDateTime");
            entity.Property(e => e.ReceiverCnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("receiverCNIC");
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("receiverName");
        });

        modelBuilder.Entity<SghOrdersStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_ORDERS_STG");

            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deliveryMethod");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.Destinationid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("destinationid");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.MnpStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("mnp_status");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("partnerOrderId");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReturnCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("return_code");
            entity.Property(e => e.RmsStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("rms_status");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<SghOrdersTst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sgh_orders_tst");

            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deliveryMethod");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.Destinationid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("destinationid");
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.MnpStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("mnp_status");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("partnerOrderId");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReturnCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("return_code");
            entity.Property(e => e.RmsStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("rms_status");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<SghReserveSku>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_RESERVE_SKU");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantity");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
        });

        modelBuilder.Entity<SghReserveSkuStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_RESERVE_SKU_STG");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantity");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
        });

        modelBuilder.Entity<SghSkuCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SKU_CODE");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode1)
                .HasMaxLength(255)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.SkuCategory)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SKU_CATEGORY");
            entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");
            entity.Property(e => e.StockQtyEstore).HasColumnName("STOCK_QTY_ESTORE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SghSkuCodeBkup20072024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SKU_CODE_BKUP20072024");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.SkuCategory)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SKU_CATEGORY");
            entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");
            entity.Property(e => e.StockQtyEstore).HasColumnName("STOCK_QTY_ESTORE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SghSkuCodeStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SKU_CODE_STG");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.SkuCategory)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SKU_CATEGORY");
            entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");
            entity.Property(e => e.StockQtyEstore).HasColumnName("STOCK_QTY_ESTORE");
        });

        modelBuilder.Entity<SghSkuStockDepot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SKU_STOCK_DEPOT");

            entity.Property(e => e.ChItem)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.DepotCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DEPOT_CODE");
            entity.Property(e => e.DepotId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.StockQty)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("STOCK_QTY");
        });

        modelBuilder.Entity<SghSkuTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SKU_TMP");

            entity.Property(e => e.AccountGroup)
                .HasMaxLength(255)
                .HasColumnName("ACCOUNT GROUP");
            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.F7).HasMaxLength(255);
            entity.Property(e => e.ModelDetails)
                .HasMaxLength(255)
                .HasColumnName("Model Details ");
            entity.Property(e => e.SamsungSkuCode)
                .HasMaxLength(255)
                .HasColumnName("SAMSUNG SKU CODE");
            entity.Property(e => e.Sku).HasColumnName("SKU");
            entity.Property(e => e.SkuDesc)
                .HasMaxLength(255)
                .HasColumnName("SKU DESC");
        });

        modelBuilder.Entity<SghSplitOrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SPLIT_ORDER_DETAILS");

            entity.HasIndex(e => e.ConsignmentId, "nci_wi_SGH_SPLIT_ORDER_DETAILS_097DC55685A7EA467AC11DE39243561D");

            entity.HasIndex(e => e.ChildOrderId, "nci_wi_SGH_SPLIT_ORDER_DETAILS_EE2DCEFB53C2B2D76FE5737FE0354658");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.DiscAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discAmount");
            entity.Property(e => e.DiscRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discRate");
            entity.Property(e => e.IncFeeAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("incFeeAmount");
            entity.Property(e => e.IncTaxAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("incTaxAmount");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.LineItemTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("lineItemTotal");
            entity.Property(e => e.Price)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantity");
            entity.Property(e => e.QuantityOrdered)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantityOrdered");
            entity.Property(e => e.QuantityReturned)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantityReturned");
            entity.Property(e => e.QuantityShipped)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantityShipped");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxRate");
        });

        modelBuilder.Entity<SghSplitOrderDetails27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SPLIT_ORDER_DETAILS_27052022");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.DiscAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discAmount");
            entity.Property(e => e.DiscRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discRate");
            entity.Property(e => e.IncFeeAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("incFeeAmount");
            entity.Property(e => e.IncTaxAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("incTaxAmount");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.LineItemTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("lineItemTotal");
            entity.Property(e => e.Price)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantity");
            entity.Property(e => e.QuantityOrdered)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantityOrdered");
            entity.Property(e => e.QuantityReturned)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantityReturned");
            entity.Property(e => e.QuantityShipped)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantityShipped");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxRate");
        });

        modelBuilder.Entity<SghSplitOrderDetailsStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SPLIT_ORDER_DETAILS_STG");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.DiscAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discAmount");
            entity.Property(e => e.DiscRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("discRate");
            entity.Property(e => e.IncFeeAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("incFeeAmount");
            entity.Property(e => e.IncTaxAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("incTaxAmount");
            entity.Property(e => e.LineItemId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lineItemId");
            entity.Property(e => e.LineItemTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("lineItemTotal");
            entity.Property(e => e.Price)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantity");
            entity.Property(e => e.QuantityOrdered)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantityOrdered");
            entity.Property(e => e.QuantityReturned)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantityReturned");
            entity.Property(e => e.QuantityShipped)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quantityShipped");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxRate)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxRate");
        });

        modelBuilder.Entity<SghSplitOrderReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SPLIT_ORDER_RETURNS");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reason_code");
            entity.Property(e => e.ReceivedQuantity).HasColumnName("receivedQuantity");
            entity.Property(e => e.ReturnedQuantity).HasColumnName("returnedQuantity");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
        });

        modelBuilder.Entity<SghSplitOrderReturns27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SPLIT_ORDER_RETURNS_27052022");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reason_code");
            entity.Property(e => e.ReceivedQuantity).HasColumnName("receivedQuantity");
            entity.Property(e => e.ReturnedQuantity).HasColumnName("returnedQuantity");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
        });

        modelBuilder.Entity<SghSplitOrderReturnsStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SPLIT_ORDER_RETURNS_STG");

            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reason_code");
            entity.Property(e => e.ReceivedQuantity).HasColumnName("receivedQuantity");
            entity.Property(e => e.ReturnedQuantity).HasColumnName("returnedQuantity");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");
        });

        modelBuilder.Entity<SghSplitOrdersHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SPLIT_ORDERS_HEADER");

            entity.HasIndex(e => new { e.PartnerOrderId, e.ConsignmentId }, "nci_wi_SGH_SPLIT_ORDERS_HEADER_5FDFE44C502733C346C63033B4A5A145");

            entity.HasIndex(e => e.ChildOrderId, "nci_wi_SGH_SPLIT_ORDERS_HEADER_A9F68975A68A0024EC5599708B547652");

            entity.Property(e => e.ApptakrefNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apptakref_num");
            entity.Property(e => e.BaCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_city");
            entity.Property(e => e.BaCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_companyName");
            entity.Property(e => e.BaContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_contactName");
            entity.Property(e => e.BaContactPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ba_contactPhone");
            entity.Property(e => e.BaCountry)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ba_country");
            entity.Property(e => e.BaLine1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ba_line1");
            entity.Property(e => e.BaLine2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ba_line2");
            entity.Property(e => e.BaPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ba_postalCode");
            entity.Property(e => e.BaState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_state");
            entity.Property(e => e.CancelReason)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cancel_reason");
            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.Cnic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.ConsignmentNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_num");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.CsCnic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_cnic");
            entity.Property(e => e.CsCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_companyName");
            entity.Property(e => e.CsCustomerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_customerId");
            entity.Property(e => e.CsEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_email");
            entity.Property(e => e.CsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_name");
            entity.Property(e => e.CsPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cs_phone");
            entity.Property(e => e.CsTitle)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cs_title");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deliveryMethod");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.DestinationId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("destinationId");
            entity.Property(e => e.LoadsheetrefNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loadsheetref_num");
            entity.Property(e => e.MnpAssignedDepotId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("mnp_assignedDepotID");
            entity.Property(e => e.OrderCategory)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("order_category");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.OrdershippedDt)
                .HasColumnType("datetime")
                .HasColumnName("ordershipped_dt");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("partnerOrderId");
            entity.Property(e => e.Paymentmode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("paymentmode");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updatedon)
                .HasColumnType("datetime")
                .HasColumnName("updatedon");
        });

        modelBuilder.Entity<SghSplitOrdersHeader27052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SPLIT_ORDERS_HEADER_27052022");

            entity.Property(e => e.ApptakrefNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apptakref_num");
            entity.Property(e => e.BaCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_city");
            entity.Property(e => e.BaCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_companyName");
            entity.Property(e => e.BaContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_contactName");
            entity.Property(e => e.BaContactPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ba_contactPhone");
            entity.Property(e => e.BaCountry)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ba_country");
            entity.Property(e => e.BaLine1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ba_line1");
            entity.Property(e => e.BaLine2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ba_line2");
            entity.Property(e => e.BaPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ba_postalCode");
            entity.Property(e => e.BaState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_state");
            entity.Property(e => e.CancelReason)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cancel_reason");
            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.Cnic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.ConsignmentNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_num");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.CsCnic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_cnic");
            entity.Property(e => e.CsCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_companyName");
            entity.Property(e => e.CsCustomerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_customerId");
            entity.Property(e => e.CsEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_email");
            entity.Property(e => e.CsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_name");
            entity.Property(e => e.CsPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cs_phone");
            entity.Property(e => e.CsTitle)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cs_title");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deliveryMethod");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.DestinationId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("destinationId");
            entity.Property(e => e.LoadsheetrefNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loadsheetref_num");
            entity.Property(e => e.MnpAssignedDepotId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("mnp_assignedDepotID");
            entity.Property(e => e.OrderCategory)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("order_category");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.OrdershippedDt)
                .HasColumnType("datetime")
                .HasColumnName("ordershipped_dt");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("partnerOrderId");
            entity.Property(e => e.Paymentmode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("paymentmode");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<SghSplitOrdersHeaderStg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SGH_SPLIT_ORDERS_HEADER_STG");

            entity.Property(e => e.ApptakrefNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apptakref_num");
            entity.Property(e => e.BaCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_city");
            entity.Property(e => e.BaCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_companyName");
            entity.Property(e => e.BaContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_contactName");
            entity.Property(e => e.BaContactPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_contactPhone");
            entity.Property(e => e.BaCountry)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ba_country");
            entity.Property(e => e.BaLine1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ba_line1");
            entity.Property(e => e.BaLine2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ba_line2");
            entity.Property(e => e.BaPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ba_postalCode");
            entity.Property(e => e.BaState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ba_state");
            entity.Property(e => e.CancelReason)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cancel_reason");
            entity.Property(e => e.ChildOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("childOrderId");
            entity.Property(e => e.Cnic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cnic");
            entity.Property(e => e.ConsignmentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_id");
            entity.Property(e => e.ConsignmentNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("consignment_num");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("createdDatetime");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.CsCnic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_cnic");
            entity.Property(e => e.CsCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_companyName");
            entity.Property(e => e.CsCustomerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_customerId");
            entity.Property(e => e.CsEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_email");
            entity.Property(e => e.CsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cs_name");
            entity.Property(e => e.CsPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cs_phone");
            entity.Property(e => e.CsTitle)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cs_title");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deliveryMethod");
            entity.Property(e => e.DeliveryOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deliveryOrderId");
            entity.Property(e => e.DestinationId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("destinationId");
            entity.Property(e => e.LoadsheetrefNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loadsheetref_num");
            entity.Property(e => e.MnpAssignedDepotId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("mnp_assignedDepotID");
            entity.Property(e => e.OrderCategory)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("order_category");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("orderType");
            entity.Property(e => e.OrdershippedDt)
                .HasColumnType("datetime")
                .HasColumnName("ordershipped_dt");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("partnerOrderId");
            entity.Property(e => e.Paymentmode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("paymentmode");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<Sheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sheet1$");

            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(255)
                .HasColumnName("estoreOrderId");
            entity.Property(e => e.Pod)
                .HasMaxLength(255)
                .HasColumnName("POD");
        });

        modelBuilder.Entity<Slider>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Slider");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.ImageName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IMAGE_NAME");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .HasColumnName("IMAGE_URL");
            entity.Property(e => e.MobileAppKeyword)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("Mobile_App_Keyword");
            entity.Property(e => e.OrderNo)
                .HasDefaultValue(0)
                .HasColumnName("ORDER_NO");
            entity.Property(e => e.StoreType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STORE_TYPE");
            entity.Property(e => e.Text1)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("TEXT1");
            entity.Property(e => e.Text2)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("TEXT2");
            entity.Property(e => e.Text3)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("TEXT3");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Url)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<SliderPromotion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Slider_promotion");

            entity.Property(e => e.Description)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.ImageName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Image_Name");
            entity.Property(e => e.StoreType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Store_Type");
        });

        modelBuilder.Entity<SmItemMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SM_ITEM_MASTER");

            entity.Property(e => e.AccountGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("account_group");
            entity.Property(e => e.ActCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("act_code");
            entity.Property(e => e.Breadth)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("breadth");
            entity.Property(e => e.Carton1)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("carton1");
            entity.Property(e => e.Carton2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("carton2");
            entity.Property(e => e.Carton3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("carton3");
            entity.Property(e => e.Carton4)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("carton4");
            entity.Property(e => e.CompleteStop)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("complete_stop");
            entity.Property(e => e.Division)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("division");
            entity.Property(e => e.GstNregistered).HasColumnName("Gst_NRegistered");
            entity.Property(e => e.GstRegistered).HasColumnName("Gst_Registered");
            entity.Property(e => e.Hieght)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("hieght");
            entity.Property(e => e.Lenght)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("lenght");
            entity.Property(e => e.MajorStop)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("major_stop");
            entity.Property(e => e.MiniStop)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("mini_stop");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("new_cost");
            entity.Property(e => e.NewMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("new_mrsp");
            entity.Property(e => e.NewTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("new_trade");
            entity.Property(e => e.OldCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("old_cost");
            entity.Property(e => e.OldMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("old_mrsp");
            entity.Property(e => e.OldTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("old_trade");
            entity.Property(e => e.PrdCode)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("prd_code");
            entity.Property(e => e.PrdGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("prd_group");
            entity.Property(e => e.PrdName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prd_name");
            entity.Property(e => e.PrdSize)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prd_size");
            entity.Property(e => e.PrdType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("prd_type");
            entity.Property(e => e.PrdWieght)
                .HasColumnType("decimal(16, 3)")
                .HasColumnName("prd_wieght");
            entity.Property(e => e.Prod1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod1");
            entity.Property(e => e.Prod1Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod1_desc");
            entity.Property(e => e.Prod2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod2");
            entity.Property(e => e.Prod2Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod2_desc");
            entity.Property(e => e.Prod3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod3");
            entity.Property(e => e.Prod3Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod3_desc");
            entity.Property(e => e.Prod4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod4");
            entity.Property(e => e.Prod4Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod4_desc");
            entity.Property(e => e.Prod5)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod5");
            entity.Property(e => e.Prod5Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod5_desc");
            entity.Property(e => e.Prod6)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod6");
            entity.Property(e => e.Prod6Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod6_desc");
            entity.Property(e => e.Prod7)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod7");
            entity.Property(e => e.Prod7Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod7_desc");
            entity.Property(e => e.Prod8)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod8");
            entity.Property(e => e.Prod8Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod8_desc");
            entity.Property(e => e.Prod9)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod9");
            entity.Property(e => e.Prod9Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod9_desc");
            entity.Property(e => e.STax1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("s_tax1");
            entity.Property(e => e.STax2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("s_tax2");
            entity.Property(e => e.STax3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("s_tax3");
            entity.Property(e => e.STaxFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("s_tax_flag");
            entity.Property(e => e.SalesGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("sales_group");
            entity.Property(e => e.StorageCondition)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("storage_condition");
            entity.Property(e => e.TheropaticGroup)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("theropatic_group");
        });

        modelBuilder.Entity<SmItemMaster1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SM_ITEM_MASTER1");

            entity.Property(e => e.AccountGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("account_group");
            entity.Property(e => e.ActCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("act_code");
            entity.Property(e => e.Breadth)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("breadth");
            entity.Property(e => e.Carton1)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("carton1");
            entity.Property(e => e.Carton2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("carton2");
            entity.Property(e => e.Carton3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("carton3");
            entity.Property(e => e.Carton4)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("carton4");
            entity.Property(e => e.CompleteStop)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("complete_stop");
            entity.Property(e => e.Division)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("division");
            entity.Property(e => e.Hieght)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("hieght");
            entity.Property(e => e.Lenght)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("lenght");
            entity.Property(e => e.MajorStop)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("major_stop");
            entity.Property(e => e.MiniStop)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("mini_stop");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("new_cost");
            entity.Property(e => e.NewMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("new_mrsp");
            entity.Property(e => e.NewTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("new_trade");
            entity.Property(e => e.OldCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("old_cost");
            entity.Property(e => e.OldMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("old_mrsp");
            entity.Property(e => e.OldTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("old_trade");
            entity.Property(e => e.PrdCode)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("prd_code");
            entity.Property(e => e.PrdGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("prd_group");
            entity.Property(e => e.PrdName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prd_name");
            entity.Property(e => e.PrdSize)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prd_size");
            entity.Property(e => e.PrdType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("prd_type");
            entity.Property(e => e.PrdWieght)
                .HasColumnType("decimal(16, 3)")
                .HasColumnName("prd_wieght");
            entity.Property(e => e.Prod1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod1");
            entity.Property(e => e.Prod1Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod1_desc");
            entity.Property(e => e.Prod2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod2");
            entity.Property(e => e.Prod2Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod2_desc");
            entity.Property(e => e.Prod3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod3");
            entity.Property(e => e.Prod3Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod3_desc");
            entity.Property(e => e.Prod4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod4");
            entity.Property(e => e.Prod4Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod4_desc");
            entity.Property(e => e.Prod5)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod5");
            entity.Property(e => e.Prod5Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod5_desc");
            entity.Property(e => e.Prod6)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod6");
            entity.Property(e => e.Prod6Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod6_desc");
            entity.Property(e => e.Prod7)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod7");
            entity.Property(e => e.Prod7Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod7_desc");
            entity.Property(e => e.Prod8)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod8");
            entity.Property(e => e.Prod8Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod8_desc");
            entity.Property(e => e.Prod9)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("prod9");
            entity.Property(e => e.Prod9Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("prod9_desc");
            entity.Property(e => e.STax1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("s_tax1");
            entity.Property(e => e.STax2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("s_tax2");
            entity.Property(e => e.STax3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("s_tax3");
            entity.Property(e => e.STaxFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("s_tax_flag");
            entity.Property(e => e.SalesGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("sales_group");
            entity.Property(e => e.StorageCondition)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("storage_condition");
            entity.Property(e => e.TheropaticGroup)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("theropatic_group");
        });

        modelBuilder.Entity<SmPspOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SM_PSP_O__3214EC27954649AD");

            entity.ToTable("SM_PSP_ORDER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CallId)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("call_id");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CityName)
                .HasMaxLength(99)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.ClinicName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clinic_name");
            entity.Property(e => e.CnicNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cnic_no");
            entity.Property(e => e.Comments)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("comments");
            entity.Property(e => e.DateEntry).HasColumnName("date_entry");
            entity.Property(e => e.DateModify).HasColumnName("date_modify");
            entity.Property(e => e.Distributor)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("distributor");
            entity.Property(e => e.Division)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("division");
            entity.Property(e => e.DocId).HasColumnName("doc_id");
            entity.Property(e => e.DocName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("doc_name");
            entity.Property(e => e.DoctorRef)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("doctor_ref");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_id");
            entity.Property(e => e.NetAmount)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("net_amount");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.OrderNature)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("order_nature");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("order_no");
            entity.Property(e => e.OrderTrackingNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("order_tracking_no");
            entity.Property(e => e.PatientId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("patient_id");
            entity.Property(e => e.PatientName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("patient_name");
            entity.Property(e => e.PrimaryMobileNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("primary_mobile_no");
            entity.Property(e => e.ProgramCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("programCode");
            entity.Property(e => e.PspTerritoryId).HasColumnName("psp_territory_id");
            entity.Property(e => e.PspTerritoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("psp_territory_name");
            entity.Property(e => e.RequiredBy).HasColumnName("required_by");
            entity.Property(e => e.SecondaryMobileNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("secondary_mobile_no");
            entity.Property(e => e.Status)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("status");
            entity.Property(e => e.TerritoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("territory_name");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_entry");
            entity.Property(e => e.UserModify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_modify");
        });

        modelBuilder.Entity<SmPspOrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SM_PSP_O__3214EC2738D12CEF");

            entity.ToTable("SM_PSP_ORDER_DETAIL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.BuName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bu_name");
            entity.Property(e => e.Discount)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountPer)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("discount_per");
            entity.Property(e => e.FreeUnits)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("free_units");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PriceOn)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("price_on");
            entity.Property(e => e.ProdId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("prod_id");
            entity.Property(e => e.ProdName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("prod_name");
            entity.Property(e => e.PspPrice)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("psp_price");
            entity.Property(e => e.Sku)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.SmPspOrderId).HasColumnName("sm_psp_order_id");
            entity.Property(e => e.Units)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("units");

            entity.HasOne(d => d.SmPspOrder).WithMany(p => p.SmPspOrderDetails)
                .HasForeignKey(d => d.SmPspOrderId)
                .HasConstraintName("FK__SM_PSP_OR__sm_ps__4BD727B2");
        });

        modelBuilder.Entity<SmsContent>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.ContentId }).HasName("PK_SMS_CONTENT");

            entity.ToTable("SMS_CONTENTS");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.ContentId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CONTENT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.SmsContent1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SMS_CONTENT");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<SmsContentTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SMS_Cont__3213E83F4F11A1C8");

            entity.ToTable("SMS_Content_TEMP");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.SmsContent)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SMS_Content");
            entity.Property(e => e.SmsContentCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SMS_Content_code");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<SmsLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMS_LOG");

            entity.Property(e => e.ConsigneeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdon");
            entity.Property(e => e.Item1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("item1");
            entity.Property(e => e.Item2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("item2");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("schedule_time");
            entity.Property(e => e.SentOn)
                .HasColumnType("datetime")
                .HasColumnName("sent_on");
            entity.Property(e => e.SmsId).HasColumnName("sms_ID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<SmsPendingQueue>(entity =>
        {
            entity.HasKey(e => e.SmsId).HasName("PK__sms_pend__72F7EF06EE03F994");

            entity.ToTable("SMS_PENDING_QUEUE");

            entity.Property(e => e.SmsId).HasColumnName("SMS_ID");
            entity.Property(e => e.Consigneename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONSIGNEENAME");
            entity.Property(e => e.Createdby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Item1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM2");
            entity.Property(e => e.Message).HasColumnName("MESSAGE");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.ScheduleTime)
                .HasColumnType("datetime")
                .HasColumnName("SCHEDULE_TIME");
        });

        modelBuilder.Entity<SmsStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMS_STATUS");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.ContentId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CONTENT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Error)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("ERROR");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ERROR_CODE");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.MessageContent)
                .HasMaxLength(1200)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_CONTENT");
            entity.Property(e => e.MessageId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MESSAGE_ID");
            entity.Property(e => e.Recepient)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RECEPIENT");
            entity.Property(e => e.Status).HasColumnName("STATUS");

            entity.HasOne(d => d.SmsContent).WithMany()
                .HasForeignKey(d => new { d.Company, d.ContentId })
                .HasConstraintName("FK_SMS_CONTENT");
        });

        modelBuilder.Entity<StationaryItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STATIONARY_ITEM");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("COST");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.StnItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STN_ITEM");
            entity.Property(e => e.StnItemFullName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STN_ITEM_FULL_NAME");
            entity.Property(e => e.StnItemShortName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STN_ITEM_SHORT_NAME");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<StockPickupPointAreaAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STOCK_PickupPoint_Area_assign");

            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Cityid).HasColumnName("CITYID");
            entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PickupPointId).HasColumnName("PickupPoint_ID");
            entity.Property(e => e.Preference)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Provinceid).HasColumnName("PROVINCEID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<StockPickupPointBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STOCK_PickupPoint_backup");

            entity.Property(e => e.CityId)
                .HasMaxLength(20)
                .HasColumnName("CityID");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Contact_No");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Contact_person");
            entity.Property(e => e.CountryId)
                .HasMaxLength(4)
                .HasColumnName("CountryID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmailId)
                .HasMaxLength(40)
                .HasColumnName("EmailID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PickupPointId)
                .HasMaxLength(10)
                .HasColumnName("PickupPoint_ID");
            entity.Property(e => e.PickupPointNameLdesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PickupPoint_Name_ldesc");
            entity.Property(e => e.PickupPointNameSdesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PickupPoint_Name_sdesc");
            entity.Property(e => e.ProvinceId)
                .HasMaxLength(4)
                .HasColumnName("ProvinceID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<StockPickupPointSellCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stock_Pi__3214EC27E5FBA056");

            entity.ToTable("Stock_PickupPoint_SellCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.PickupPointid).HasColumnName("PIckupPointid");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .HasColumnName("Sell_Category");
        });

        modelBuilder.Entity<StockPickuppoint>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Id }).HasName("PK_STOCK_PPOINT");

            entity.ToTable("STOCK_PICKUPPOINT");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("01");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Area).HasColumnName("AREA");
            entity.Property(e => e.CityId)
                .HasMaxLength(20)
                .HasColumnName("CityID");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Contact_No");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Contact_person");
            entity.Property(e => e.CountryId)
                .HasMaxLength(4)
                .HasColumnName("CountryID");
            entity.Property(e => e.CourierMapId).HasColumnName("COURIER_MAP_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Dsl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DSL");
            entity.Property(e => e.EmailId)
                .HasMaxLength(40)
                .HasColumnName("EmailID");
            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LONGITUDE");
            entity.Property(e => e.PickupPointId)
                .HasMaxLength(10)
                .HasColumnName("PickupPoint_ID");
            entity.Property(e => e.PickupPointNameLdesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PickupPoint_Name_ldesc");
            entity.Property(e => e.PickupPointNameSdesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PickupPoint_Name_sdesc");
            entity.Property(e => e.ProvinceId)
                .HasMaxLength(4)
                .HasColumnName("ProvinceID");
            entity.Property(e => e.Seller)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .HasColumnName("ZONE");
        });

        modelBuilder.Entity<StockPickuppoint1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stock_pickuppoint_1");

            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Area).HasColumnName("AREA");
            entity.Property(e => e.CityId)
                .HasMaxLength(20)
                .HasColumnName("CityID");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Contact_No");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Contact_person");
            entity.Property(e => e.CountryId)
                .HasMaxLength(4)
                .HasColumnName("CountryID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmailId)
                .HasMaxLength(40)
                .HasColumnName("EmailID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PickupPointId)
                .HasMaxLength(10)
                .HasColumnName("PickupPoint_ID");
            entity.Property(e => e.PickupPointNameLdesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PickupPoint_Name_ldesc");
            entity.Property(e => e.PickupPointNameSdesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PickupPoint_Name_sdesc");
            entity.Property(e => e.ProvinceId)
                .HasMaxLength(4)
                .HasColumnName("ProvinceID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<StockPosition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STOCK_Position");

            entity.Property(e => e.ChildItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("child_item");
            entity.Property(e => e.MasterItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Master_item");
            entity.Property(e => e.StockInUnits)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Stock_In_Units");
            entity.Property(e => e.StockOutUnits)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Stock_Out_Units");
        });

        modelBuilder.Entity<StockPositionLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STOCK_Position_log");

            entity.Property(e => e.CompanyCode).HasColumnName("COMPANY_CODE");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Model_CODE");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ref_no");
            entity.Property(e => e.Transaction)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Units).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserEntry)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("User_Entry");
        });

        modelBuilder.Entity<SubCategory>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.ScatCode });

            entity.ToTable("SUB_CATEGORY");

            entity.HasIndex(e => new { e.Status, e.Company, e.McatCode, e.MjcatCode }, "nci_wi_SUB_CATEGORY_170C9B65A2F7FB176E66CEF58448AF13").HasFillFactor(80);

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.McatCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MCAT_CODE");
            entity.Property(e => e.MjcatCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MJCAT_CODE");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ScatImage).HasColumnName("SCAT_IMAGE");
            entity.Property(e => e.ScatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCAT_NAME");
            entity.Property(e => e.ScatThumb).HasColumnName("SCAT_THUMB");
            entity.Property(e => e.Sno).HasColumnName("SNO");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");

            entity.HasOne(d => d.MajorCategory).WithMany(p => p.SubCategories)
                .HasForeignKey(d => new { d.Company, d.McatCode, d.MjcatCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAJOR_CAT");
        });

        modelBuilder.Entity<SubCategory1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SubCategory");

            entity.Property(e => e.CategoryCode).HasColumnName("Category_CODE");
            entity.Property(e => e.CompanyCode).HasColumnName("COMPANY_CODE");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.DateModify).HasColumnName("Date_Modify");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SubCategoryCode).HasColumnName("SubCategory_CODE");
            entity.Property(e => e.SubCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SubCategory_NAME");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Entry");
            entity.Property(e => e.UserModify)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<SystemCode>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodeType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codeType");
            entity.Property(e => e.CodeValue)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codeValue");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Identifier)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("identifier");
            entity.Property(e => e.Year)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("year");
        });

        modelBuilder.Entity<SzOrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.SzDetailsId, e.OrderId }).HasName("PK_SZ_ORDER_DETAILS_1");

            entity.ToTable("SZ_ORDER_DETAILS");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasColumnName("COMPANY");
            entity.Property(e => e.SzDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SZ_DETAILS_ID");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_CODE");
            entity.Property(e => e.Customername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMERNAME");
            entity.Property(e => e.Depot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPOT_NAME");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("GST");
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INVOICE_DATE");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INVOICE_NUMBER");
            entity.Property(e => e.Invoiceamount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("INVOICEAMOUNT");
            entity.Property(e => e.Outstanding)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OUTSTANDING");
            entity.Property(e => e.ReturnType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RETURN_TYPE");
            entity.Property(e => e.SzStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SZ_STATUS");
        });

        modelBuilder.Entity<TaUser>(entity =>
        {
            entity.HasKey(e => new { e.CompanyCode, e.UserCode });

            entity.ToTable("ta_Users");

            entity.HasIndex(e => new { e.UserType, e.Status }, "nci_wi_ta_Users_4742C94ED99708E7CA1D976B07F0CE1F").HasFillFactor(80);

            entity.HasIndex(e => new { e.Password, e.Email }, "nci_wi_ta_Users_58913F3922BDED68149A4C92E935ED23").HasFillFactor(80);

            entity.HasIndex(e => new { e.UserCode, e.UserType }, "nci_wi_ta_Users_E27F6E5F1A636C7AE662D1129081D33E").HasFillFactor(80);

            entity.Property(e => e.CompanyCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Company_Code");
            entity.Property(e => e.UserCode)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("User_code");
            entity.Property(e => e.Area)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Billing_address");
            entity.Property(e => e.Birthday)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("birthday");
            entity.Property(e => e.ChangePassword)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("change_password");
            entity.Property(e => e.City)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .HasColumnName("cnic");
            entity.Property(e => e.Country)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.DsrCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("dsr_code");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FirebaseTokenAndroid)
                .IsUnicode(false)
                .HasColumnName("firebase_token_android");
            entity.Property(e => e.FirebaseTokenIos)
                .IsUnicode(false)
                .HasColumnName("firebase_token_ios");
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate).HasColumnName("Joining_Date");
            entity.Property(e => e.Keydate)
                .HasColumnType("smalldatetime")
                .HasColumnName("keydate");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Location)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Modified_By");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("Modified_on");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Postal_Code");
            entity.Property(e => e.Province)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.RCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("r_code");
            entity.Property(e => e.ShippingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Shipping_address");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tempkey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tempkey");
            entity.Property(e => e.UserCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Company_Name");
            entity.Property(e => e.UserCompanyNick)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_Company_nick");
            entity.Property(e => e.UserType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("User_type");
            entity.Property(e => e.VendorRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Vendor_Ref");
        });

        modelBuilder.Entity<TaUsers13012023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ta_users13012023");

            entity.Property(e => e.Area)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Billing_address");
            entity.Property(e => e.Birthday)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("birthday");
            entity.Property(e => e.ChangePassword)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("change_password");
            entity.Property(e => e.City)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .HasColumnName("cnic");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Company_Code");
            entity.Property(e => e.Country)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FirebaseTokenAndroid)
                .IsUnicode(false)
                .HasColumnName("firebase_token_android");
            entity.Property(e => e.FirebaseTokenIos)
                .IsUnicode(false)
                .HasColumnName("firebase_token_ios");
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate).HasColumnName("Joining_Date");
            entity.Property(e => e.Keydate)
                .HasColumnType("smalldatetime")
                .HasColumnName("keydate");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Location)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Modified_By");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("Modified_on");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Postal_Code");
            entity.Property(e => e.Province)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.RCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("r_code");
            entity.Property(e => e.ShippingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Shipping_address");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tempkey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tempkey");
            entity.Property(e => e.UserCode)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("User_code");
            entity.Property(e => e.UserCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Company_Name");
            entity.Property(e => e.UserCompanyNick)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_Company_nick");
            entity.Property(e => e.UserType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("User_type");
            entity.Property(e => e.VendorRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Vendor_Ref");
        });

        modelBuilder.Entity<TaUsersAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ta_users_admin");

            entity.Property(e => e.Area)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Billing_address");
            entity.Property(e => e.Birthday)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("birthday");
            entity.Property(e => e.ChangePassword)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("change_password");
            entity.Property(e => e.City)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .HasColumnName("cnic");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Company_Code");
            entity.Property(e => e.Country)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.DsrCode)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("dsr_code");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FirebaseTokenAndroid)
                .IsUnicode(false)
                .HasColumnName("firebase_token_android");
            entity.Property(e => e.FirebaseTokenIos)
                .IsUnicode(false)
                .HasColumnName("firebase_token_ios");
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate).HasColumnName("Joining_Date");
            entity.Property(e => e.Keydate)
                .HasColumnType("smalldatetime")
                .HasColumnName("keydate");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Location)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Modified_By");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("Modified_on");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Postal_Code");
            entity.Property(e => e.Province)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.RCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("r_code");
            entity.Property(e => e.ShippingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Shipping_address");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tempkey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tempkey");
            entity.Property(e => e.UserCode)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("User_code");
            entity.Property(e => e.UserCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Company_Name");
            entity.Property(e => e.UserCompanyNick)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_Company_nick");
            entity.Property(e => e.UserType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("User_type");
            entity.Property(e => e.VendorRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Vendor_Ref");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tag");

            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TagId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tag_Id");
            entity.Property(e => e.TagName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tag_Name");
        });

        modelBuilder.Entity<TaxSlab>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.CountryId, e.ProvinceId });

            entity.ToTable("TAX_SLAB");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_on");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Modified_By");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("Modified_On");
            entity.Property(e => e.SalesTaxRate).HasColumnName("SalesTax_Rate");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.WithHoldingTaxRate).HasColumnName("WithHoldingTax_Rate");
        });

        modelBuilder.Entity<TblImage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_images");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image).HasColumnName("IMAGE_");
            entity.Property(e => e.Model)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("model");
            entity.Property(e => e.Tag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TAG");
        });

        modelBuilder.Entity<TblImagesItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_images_Items");

            entity.HasIndex(e => new { e.Model, e.ImageType }, "IX_tbl_images_Items_model_Image_Type").HasFillFactor(80);

            entity.HasIndex(e => e.Tag, "nci_wi_tbl_images_Items_9F92F655666DC3A09C7232617E1E80F0").HasFillFactor(80);

            entity.Property(e => e.Entrydate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entrydate");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Image).HasColumnName("IMAGE_");
            entity.Property(e => e.ImageType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Image_Type");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMAGE_URL");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("model");
            entity.Property(e => e.Status).HasColumnName("STATus");
            entity.Property(e => e.Tag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TAG");
        });

        modelBuilder.Entity<TblPspAttachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_psp_attachments");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Img).HasColumnType("image");
            entity.Property(e => e.ImgDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Img_Desc");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seq)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("seq");
        });

        modelBuilder.Entity<TblXiaomiOrder>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Tbl_Xiao__55433A4B31A5DAEB");

            entity.ToTable("Tbl_Xiaomi_Orders");

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.ConsigneeAddress).HasMaxLength(500);
            entity.Property(e => e.ConsigneeCity).HasMaxLength(50);
            entity.Property(e => e.ConsigneeCode).HasMaxLength(50);
            entity.Property(e => e.ConsigneeName).HasMaxLength(255);
            entity.Property(e => e.ConsignorCode).HasMaxLength(50);
            entity.Property(e => e.ConsignorName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DocumentNumber).HasMaxLength(15);
            entity.Property(e => e.Imei)
                .HasMaxLength(20)
                .HasColumnName("IMEI");
            entity.Property(e => e.Sn)
                .HasMaxLength(20)
                .HasColumnName("SN");
            entity.Property(e => e.Status).HasDefaultValue(false);
        });

        modelBuilder.Entity<TempB2bOutlet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_B2B_OUTLETS");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS_LINE_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS_LINE_2");
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .HasColumnName("AREA");
            entity.Property(e => e.AreaId)
                .HasMaxLength(255)
                .HasColumnName("AREA_ID");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(255)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.City)
                .HasColumnType("datetime")
                .HasColumnName("CITY");
            entity.Property(e => e.CityId)
                .HasMaxLength(255)
                .HasColumnName("CITY_ID");
            entity.Property(e => e.Cnic)
                .HasMaxLength(255)
                .HasColumnName("CNIC");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryId)
                .HasMaxLength(255)
                .HasColumnName("COUNTRY_ID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasMaxLength(255)
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.Dsl)
                .HasMaxLength(255)
                .HasColumnName("DSL");
            entity.Property(e => e.DslExpiry)
                .HasMaxLength(255)
                .HasColumnName("DSL_EXPIRY");
            entity.Property(e => e.DslType)
                .HasMaxLength(255)
                .HasColumnName("DSL_TYPE");
            entity.Property(e => e.DuplicateFinder).HasColumnName("Duplicate Finder");
            entity.Property(e => e.EmailId)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_ID");
            entity.Property(e => e.HashExpiry)
                .HasColumnType("datetime")
                .HasColumnName("HASH_EXPIRY");
            entity.Property(e => e.HashKey)
                .HasMaxLength(255)
                .HasColumnName("HASH_KEY");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("IMAGE");
            entity.Property(e => e.LandlineNo)
                .HasMaxLength(255)
                .HasColumnName("LANDLINE_NO");
            entity.Property(e => e.Ntn)
                .HasMaxLength(255)
                .HasColumnName("NTN");
            entity.Property(e => e.Owner)
                .HasMaxLength(255)
                .HasColumnName("OWNER");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PoliceStation)
                .HasMaxLength(255)
                .HasColumnName("POLICE_STATION");
            entity.Property(e => e.PostCode)
                .HasMaxLength(255)
                .HasColumnName("POST_CODE");
            entity.Property(e => e.PrimaryMobileNo)
                .HasMaxLength(255)
                .HasColumnName("PRIMARY_MOBILE_NO");
            entity.Property(e => e.Province)
                .HasMaxLength(255)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.ProvinceId)
                .HasMaxLength(255)
                .HasColumnName("PROVINCE_ID");
            entity.Property(e => e.RefCustCode1)
                .HasMaxLength(255)
                .HasColumnName("REF_CUST_CODE_1");
            entity.Property(e => e.RefCustCode2)
                .HasMaxLength(255)
                .HasColumnName("REF_CUST_CODE_2");
            entity.Property(e => e.RegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("REGISTRATION_DATE");
            entity.Property(e => e.SecondaryMobileNo)
                .HasMaxLength(255)
                .HasColumnName("SECONDARY_MOBILE_NO");
            entity.Property(e => e.SellerId)
                .HasMaxLength(255)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.SellerLocation)
                .HasMaxLength(255)
                .HasColumnName("SELLER_LOCATION");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.Strn)
                .HasMaxLength(255)
                .HasColumnName("STRN");
            entity.Property(e => e.Tehsil)
                .HasMaxLength(255)
                .HasColumnName("TEHSIL");
            entity.Property(e => e.Town)
                .HasMaxLength(255)
                .HasColumnName("TOWN");
            entity.Property(e => e.TownId)
                .HasMaxLength(255)
                .HasColumnName("TOWN_ID");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(255)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(255)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TempB2bOutlets2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_B2B_OUTLETS2");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS_LINE_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS_LINE_2");
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .HasColumnName("AREA");
            entity.Property(e => e.AreaId)
                .HasMaxLength(255)
                .HasColumnName("AREA_ID");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(255)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("CITY");
            entity.Property(e => e.CityId)
                .HasMaxLength(255)
                .HasColumnName("CITY_ID");
            entity.Property(e => e.Cnic)
                .HasMaxLength(255)
                .HasColumnName("CNIC");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryId)
                .HasMaxLength(255)
                .HasColumnName("COUNTRY_ID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasMaxLength(255)
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.Dsl)
                .HasMaxLength(255)
                .HasColumnName("DSL");
            entity.Property(e => e.DslExpiry)
                .HasMaxLength(255)
                .HasColumnName("DSL_EXPIRY");
            entity.Property(e => e.DslType)
                .HasMaxLength(255)
                .HasColumnName("DSL_TYPE");
            entity.Property(e => e.EmailId)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_ID");
            entity.Property(e => e.HashExpiry)
                .HasColumnType("datetime")
                .HasColumnName("HASH_EXPIRY");
            entity.Property(e => e.HashKey)
                .HasMaxLength(255)
                .HasColumnName("HASH_KEY");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("IMAGE");
            entity.Property(e => e.LandlineNo)
                .HasMaxLength(255)
                .HasColumnName("LANDLINE_NO");
            entity.Property(e => e.Ntn)
                .HasMaxLength(255)
                .HasColumnName("NTN");
            entity.Property(e => e.Owner)
                .HasMaxLength(255)
                .HasColumnName("OWNER");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PoliceStation)
                .HasMaxLength(255)
                .HasColumnName("POLICE_STATION");
            entity.Property(e => e.PostCode)
                .HasMaxLength(255)
                .HasColumnName("POST_CODE");
            entity.Property(e => e.PrimaryMobileNo)
                .HasMaxLength(255)
                .HasColumnName("PRIMARY_MOBILE_NO");
            entity.Property(e => e.Province)
                .HasMaxLength(255)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.ProvinceId)
                .HasMaxLength(255)
                .HasColumnName("PROVINCE_ID");
            entity.Property(e => e.RefCustCode1)
                .HasMaxLength(255)
                .HasColumnName("REF_CUST_CODE_1");
            entity.Property(e => e.RefCustCode2)
                .HasMaxLength(255)
                .HasColumnName("REF_CUST_CODE_2");
            entity.Property(e => e.RegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("REGISTRATION_DATE");
            entity.Property(e => e.SecondaryMobileNo)
                .HasMaxLength(255)
                .HasColumnName("SECONDARY_MOBILE_NO");
            entity.Property(e => e.SellerId)
                .HasMaxLength(255)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.SellerLocation)
                .HasMaxLength(255)
                .HasColumnName("SELLER_LOCATION");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.Strn)
                .HasMaxLength(255)
                .HasColumnName("STRN");
            entity.Property(e => e.Tehsil)
                .HasMaxLength(255)
                .HasColumnName("TEHSIL");
            entity.Property(e => e.Town)
                .HasMaxLength(255)
                .HasColumnName("TOWN");
            entity.Property(e => e.TownId)
                .HasMaxLength(255)
                .HasColumnName("TOWN_ID");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(255)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(255)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TempChildItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CHILD_ITEM");

            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM_FULL_NAME");
            entity.Property(e => e.ChItemShortName)
                .HasMaxLength(50)
                .HasColumnName("CH_ITEM_SHORT_NAME");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TempCustomerCatAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CUSTOMER_CAT_ASSIGN");

            entity.Property(e => e.CategoryId)
                .HasMaxLength(255)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasMaxLength(255)
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.SellerId)
                .HasMaxLength(255)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.SellerLocation)
                .HasMaxLength(255)
                .HasColumnName("SELLER_LOCATION");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(255)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(255)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TempIbft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_IBFT");

            entity.Property(e => e.BookingDate)
                .HasMaxLength(255)
                .HasColumnName("bookingDate");
            entity.Property(e => e.CnType)
                .HasMaxLength(255)
                .HasColumnName("CN Type");
            entity.Property(e => e.Cnstatus)
                .HasMaxLength(255)
                .HasColumnName("CNStatus");
            entity.Property(e => e.Codamount)
                .HasMaxLength(255)
                .HasColumnName("CODAMOUNT");
            entity.Property(e => e.Consignee)
                .HasMaxLength(255)
                .HasColumnName("consignee");
            entity.Property(e => e.ConsignmentNumber)
                .HasMaxLength(255)
                .HasColumnName("consignmentNumber");
            entity.Property(e => e.Destination)
                .HasMaxLength(255)
                .HasColumnName("destination");
            entity.Property(e => e.InstrumentNumber).HasMaxLength(255);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(255)
                .HasColumnName("orderRefNo");
            entity.Property(e => e.Origin)
                .HasMaxLength(255)
                .HasColumnName("origin");
            entity.Property(e => e.PaymentId).HasMaxLength(255);
            entity.Property(e => e.Rrdate)
                .HasMaxLength(255)
                .HasColumnName("RRDATE");
            entity.Property(e => e.ShippingCharges).HasMaxLength(255);
            entity.Property(e => e.Weight)
                .HasMaxLength(255)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<TempIbft2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_IBFT2");

            entity.Property(e => e.BookingDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING_DATE");
            entity.Property(e => e.Cn).HasColumnName("CN");
            entity.Property(e => e.CnStatus)
                .HasMaxLength(255)
                .HasColumnName("CN_STATUS");
            entity.Property(e => e.CodaMount).HasColumnName("CODA_MOUNT");
            entity.Property(e => e.Consignee)
                .HasMaxLength(255)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.Destination)
                .HasMaxLength(255)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(255)
                .HasColumnName("INVOICE_NUMBER");
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(255)
                .HasColumnName("ORDER_REF_NO");
            entity.Property(e => e.Origin)
                .HasMaxLength(255)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.Rrdate)
                .HasMaxLength(255)
                .HasColumnName("RRDATE");
            entity.Property(e => e.ShippingCharges)
                .HasMaxLength(255)
                .HasColumnName("SHIPPING_CHARGES");
            entity.Property(e => e.TransactionNumber)
                .HasMaxLength(255)
                .HasColumnName("TRANSACTION_NUMBER");
            entity.Property(e => e.Weight)
                .HasMaxLength(255)
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<TempItemCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_ITEM_CATEGORY");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TempItemDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_ITEM_DESCRIPTION");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.DescDetail)
                .IsUnicode(false)
                .HasColumnName("DESC_DETAIL");
            entity.Property(e => e.DescLabel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESC_LABEL");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TempItemStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_ITEM_STOCK");

            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Stock).HasColumnName("STOCK");
            entity.Property(e => e.StockType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STOCK_TYPE");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSE");
        });

        modelBuilder.Entity<TempMasterItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_MASTER_ITEM");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Delivery)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Item1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item1Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM1_NAME");
            entity.Property(e => e.Item2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM2");
            entity.Property(e => e.Item2Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM2_NAME");
            entity.Property(e => e.Item3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM3");
            entity.Property(e => e.Item3Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM3_NAME");
            entity.Property(e => e.Item4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM4");
            entity.Property(e => e.Item4Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM4_NAME");
            entity.Property(e => e.Item5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM5");
            entity.Property(e => e.Item5Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM5_NAME");
            entity.Property(e => e.Item6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM6");
            entity.Property(e => e.Item6Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM6_NAME");
            entity.Property(e => e.Item7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM7");
            entity.Property(e => e.Item7Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM7_NAME");
            entity.Property(e => e.Item8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM8");
            entity.Property(e => e.Item8Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM8_NAME");
            entity.Property(e => e.Item9)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM9");
            entity.Property(e => e.Item9Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM9_NAME");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ITEM_FULL_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.Prescription).HasColumnName("PRESCRIPTION");
            entity.Property(e => e.RefCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TempNovoOrderStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_novo_order_status");

            entity.Property(e => e.ApptakStatus).HasColumnName("apptak_status");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("order_no");
            entity.Property(e => e.PspStatus).HasColumnName("psp_status");
            entity.Property(e => e.RequiredBy).HasColumnName("required_by");
            entity.Property(e => e.Value)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempProductInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_Product_Info");

            entity.Property(e => e.Brand)
                .HasMaxLength(255)
                .HasColumnName("BRAND");
            entity.Property(e => e.BrandId)
                .HasMaxLength(255)
                .HasColumnName("BRAND_ID");
            entity.Property(e => e.CartonSize).HasColumnName("CARTON_SIZE");
            entity.Property(e => e.CategoryDesc)
                .HasMaxLength(255)
                .HasColumnName("CATEGORY_DESC");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(255)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Cost).HasColumnName("COST");
            entity.Property(e => e.DateEntry)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTRY");
            entity.Property(e => e.DateModify)
                .HasMaxLength(255)
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.Division)
                .HasMaxLength(255)
                .HasColumnName("DIVISION");
            entity.Property(e => e.DivisionId)
                .HasMaxLength(255)
                .HasColumnName("DIVISION_ID");
            entity.Property(e => e.Height).HasColumnName("HEIGHT");
            entity.Property(e => e.Length).HasColumnName("LENGTH");
            entity.Property(e => e.LongDesc)
                .HasMaxLength(255)
                .HasColumnName("LONG_DESC");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(255)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.ManufacturerId)
                .HasMaxLength(255)
                .HasColumnName("MANUFACTURER_ID");
            entity.Property(e => e.Mrsp).HasColumnName("MRSP");
            entity.Property(e => e.Product)
                .HasMaxLength(255)
                .HasColumnName("PRODUCT");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellerId)
                .HasMaxLength(255)
                .HasColumnName("SELLER_ID");
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(255)
                .HasColumnName("SHORT_DESC");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TaxPer).HasColumnName("TAX_PER");
            entity.Property(e => e.TaxType)
                .HasMaxLength(255)
                .HasColumnName("TAX_TYPE");
            entity.Property(e => e.Trade).HasColumnName("TRADE");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("TYPE");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(255)
                .HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(255)
                .HasColumnName("USER_MODIFY");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            entity.Property(e => e.Width).HasColumnName("WIDTH");
        });

        modelBuilder.Entity<TmpApCitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_ap_citems");

            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_FULL_NAME");
            entity.Property(e => e.ChItemShortName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_SHORT_NAME");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.F3).HasMaxLength(255);
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasMaxLength(255)
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasMaxLength(255)
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasMaxLength(255)
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasMaxLength(255)
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpApIcat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_ap_icat");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(255)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpApMitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_ap_mitems");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Delivery).HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.F41).HasMaxLength(255);
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("IMAGE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.Item1)
                .HasMaxLength(255)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item1Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM1_NAME");
            entity.Property(e => e.Item2)
                .HasMaxLength(255)
                .HasColumnName("ITEM2");
            entity.Property(e => e.Item2Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM2_NAME");
            entity.Property(e => e.Item3)
                .HasMaxLength(255)
                .HasColumnName("ITEM3");
            entity.Property(e => e.Item3Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM3_NAME");
            entity.Property(e => e.Item4)
                .HasMaxLength(255)
                .HasColumnName("ITEM4");
            entity.Property(e => e.Item4Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM4_NAME");
            entity.Property(e => e.Item5)
                .HasMaxLength(255)
                .HasColumnName("ITEM5");
            entity.Property(e => e.Item5Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM5_NAME");
            entity.Property(e => e.Item6)
                .HasMaxLength(255)
                .HasColumnName("ITEM6");
            entity.Property(e => e.Item6Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM6_NAME");
            entity.Property(e => e.Item7)
                .HasMaxLength(255)
                .HasColumnName("ITEM7");
            entity.Property(e => e.Item7Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM7_NAME");
            entity.Property(e => e.Item8)
                .HasMaxLength(255)
                .HasColumnName("ITEM8");
            entity.Property(e => e.Item8Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM8_NAME");
            entity.Property(e => e.Item9)
                .HasMaxLength(255)
                .HasColumnName("ITEM9");
            entity.Property(e => e.Item9Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM9_NAME");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_FULL_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.MasterCode)
                .HasMaxLength(255)
                .HasColumnName("Master Code ");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasMaxLength(255)
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasMaxLength(255)
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasMaxLength(255)
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasMaxLength(255)
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(255)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Seller)
                .HasMaxLength(255)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpApptakCor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_APPTAK_COR");

            entity.Property(e => e.ApptakRefnum)
                .HasMaxLength(255)
                .HasColumnName("APPTAK_REFNUM");
            entity.Property(e => e.Customername)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMERNAME");
            entity.Property(e => e.OrderId)
                .HasMaxLength(255)
                .HasColumnName("ORDER_ID");
        });

        modelBuilder.Entity<TmpApptakItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_apptak_item");

            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
        });

        modelBuilder.Entity<TmpApptakPrice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_apptak_prices");

            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("ch_item");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(255)
                .HasColumnName("ch_item_full_name");
            entity.Property(e => e.Item)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("item");
            entity.Property(e => e.NewMrsp).HasColumnName("new_mrsp");
            entity.Property(e => e.NewTrade).HasColumnName("new_trade");
            entity.Property(e => e.OldMrsp).HasColumnName("old_mrsp");
        });

        modelBuilder.Entity<TmpBhCitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_BH_CITEMS");

            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_FULL_NAME");
            entity.Property(e => e.ChItemShortName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_SHORT_NAME");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost).HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade).HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost).HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade).HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpBhIcat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_BH_ICAT");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(255)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpBhMitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_BH_MITEMS");

            entity.Property(e => e.Delivery)
                .HasMaxLength(255)
                .HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.F40).HasMaxLength(255);
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("IMAGE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.Item1)
                .HasMaxLength(255)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item1Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM1_NAME");
            entity.Property(e => e.Item2)
                .HasMaxLength(255)
                .HasColumnName("ITEM2");
            entity.Property(e => e.Item2Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM2_NAME");
            entity.Property(e => e.Item3)
                .HasMaxLength(255)
                .HasColumnName("ITEM3");
            entity.Property(e => e.Item3Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM3_NAME");
            entity.Property(e => e.Item4)
                .HasMaxLength(255)
                .HasColumnName("ITEM4");
            entity.Property(e => e.Item4Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM4_NAME");
            entity.Property(e => e.Item5)
                .HasMaxLength(255)
                .HasColumnName("ITEM5");
            entity.Property(e => e.Item5Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM5_NAME");
            entity.Property(e => e.Item6)
                .HasMaxLength(255)
                .HasColumnName("ITEM6");
            entity.Property(e => e.Item6Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM6_NAME");
            entity.Property(e => e.Item7)
                .HasMaxLength(255)
                .HasColumnName("ITEM7");
            entity.Property(e => e.Item7Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM7_NAME");
            entity.Property(e => e.Item8)
                .HasMaxLength(255)
                .HasColumnName("ITEM8");
            entity.Property(e => e.Item8Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM8_NAME");
            entity.Property(e => e.Item9)
                .HasMaxLength(255)
                .HasColumnName("ITEM9");
            entity.Property(e => e.Item9Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM9_NAME");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_FULL_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost).HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade).HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost).HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade).HasColumnName("OLD_TRADE");
            entity.Property(e => e.Prescription)
                .HasMaxLength(255)
                .HasColumnName("PRESCRIPTION");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(255)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Seller)
                .HasMaxLength(255)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
            entity.Property(e => e._01)
                .HasMaxLength(255)
                .HasColumnName("01");
        });

        modelBuilder.Entity<TmpBhitemsUpdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_BHITEMS_UPDATE");

            entity.Property(e => e.ItemSkucode).HasColumnName("Item SKUcode");
            entity.Property(e => e.ItemTypeName)
                .HasMaxLength(255)
                .HasColumnName("Item Type Name");
            entity.Property(e => e.SpecialPrice).HasColumnName("Special Price");
            entity.Property(e => e.SumOfInventoryFinal).HasColumnName("Sum of Inventory Final");
        });

        modelBuilder.Entity<TmpFwCitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_FW_CITEMS");

            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_FULL_NAME");
            entity.Property(e => e.ChItemShortName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_SHORT_NAME");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasMaxLength(255)
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasMaxLength(255)
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasMaxLength(255)
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasMaxLength(255)
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode).HasColumnName("REF_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
            entity.Property(e => e._01)
                .HasMaxLength(255)
                .HasColumnName("01");
        });

        modelBuilder.Entity<TmpFwIcat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_FW_ICAT");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(255)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpFwMitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_FW_MITEMS");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Delivery)
                .HasMaxLength(255)
                .HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.F40).HasMaxLength(255);
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("IMAGE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.Item1)
                .HasMaxLength(255)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item1Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM1_NAME");
            entity.Property(e => e.Item2)
                .HasMaxLength(255)
                .HasColumnName("ITEM2");
            entity.Property(e => e.Item2Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM2_NAME");
            entity.Property(e => e.Item3)
                .HasMaxLength(255)
                .HasColumnName("ITEM3");
            entity.Property(e => e.Item3Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM3_NAME");
            entity.Property(e => e.Item4)
                .HasMaxLength(255)
                .HasColumnName("ITEM4");
            entity.Property(e => e.Item4Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM4_NAME");
            entity.Property(e => e.Item5)
                .HasMaxLength(255)
                .HasColumnName("ITEM5");
            entity.Property(e => e.Item5Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM5_NAME");
            entity.Property(e => e.Item6)
                .HasMaxLength(255)
                .HasColumnName("ITEM6");
            entity.Property(e => e.Item6Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM6_NAME");
            entity.Property(e => e.Item7)
                .HasMaxLength(255)
                .HasColumnName("ITEM7");
            entity.Property(e => e.Item7Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM7_NAME");
            entity.Property(e => e.Item8)
                .HasMaxLength(255)
                .HasColumnName("ITEM8");
            entity.Property(e => e.Item8Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM8_NAME");
            entity.Property(e => e.Item9)
                .HasMaxLength(255)
                .HasColumnName("ITEM9");
            entity.Property(e => e.Item9Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM9_NAME");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_FULL_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasMaxLength(255)
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasMaxLength(255)
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasMaxLength(255)
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasMaxLength(255)
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.Prescription).HasMaxLength(255);
            entity.Property(e => e.RefCode).HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(255)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Seller)
                .HasMaxLength(255)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpGeneric>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_GENERICS");

            entity.Property(e => e.ChItem)
                .HasMaxLength(50)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ColName)
                .HasMaxLength(255)
                .HasColumnName("COL_NAME");
            entity.Property(e => e.ColName1)
                .HasMaxLength(255)
                .HasColumnName("COL_NAME1");
            entity.Property(e => e.Formula)
                .HasMaxLength(255)
                .HasColumnName("FORMULA");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.TherapeuticClass)
                .HasMaxLength(255)
                .HasColumnName("THERAPEUTIC CLASS");
        });

        modelBuilder.Entity<TmpGrCitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_GR_CITEMS");

            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_FULL_NAME");
            entity.Property(e => e.ChItemShortName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_SHORT_NAME");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.F3).HasMaxLength(255);
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasMaxLength(255)
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasMaxLength(255)
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasMaxLength(255)
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasMaxLength(255)
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpGrIcat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_GR_ICAT");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(255)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpGrItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_GR_ITEMS");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Delivery).HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(255)
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.F39).HasMaxLength(255);
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("IMAGE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.Item1)
                .HasMaxLength(255)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item1Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM1_NAME");
            entity.Property(e => e.Item2)
                .HasMaxLength(255)
                .HasColumnName("ITEM2");
            entity.Property(e => e.Item2Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM2_NAME");
            entity.Property(e => e.Item3)
                .HasMaxLength(255)
                .HasColumnName("ITEM3");
            entity.Property(e => e.Item3Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM3_NAME");
            entity.Property(e => e.Item4)
                .HasMaxLength(255)
                .HasColumnName("ITEM4");
            entity.Property(e => e.Item4Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM4_NAME");
            entity.Property(e => e.Item5)
                .HasMaxLength(255)
                .HasColumnName("ITEM5");
            entity.Property(e => e.Item5Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM5_NAME");
            entity.Property(e => e.Item6)
                .HasMaxLength(255)
                .HasColumnName("ITEM6");
            entity.Property(e => e.Item6Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM6_NAME");
            entity.Property(e => e.Item7)
                .HasMaxLength(255)
                .HasColumnName("ITEM7");
            entity.Property(e => e.Item7Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM7_NAME");
            entity.Property(e => e.Item8)
                .HasMaxLength(255)
                .HasColumnName("ITEM8");
            entity.Property(e => e.Item8Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM8_NAME");
            entity.Property(e => e.Item9)
                .HasMaxLength(255)
                .HasColumnName("ITEM9");
            entity.Property(e => e.Item9Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM9_NAME");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_FULL_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasMaxLength(255)
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasMaxLength(255)
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasMaxLength(255)
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasMaxLength(255)
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(255)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Seller)
                .HasMaxLength(255)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpGrStk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_GR_STK");

            entity.Property(e => e.ChItem).HasColumnName("CH_ITEM");
            entity.Property(e => e.Company).HasColumnName("COMPANY");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.RefCode)
                .HasMaxLength(255)
                .HasColumnName("REF_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.Stock).HasColumnName("STOCK");
            entity.Property(e => e.StockType)
                .HasMaxLength(255)
                .HasColumnName("STOCK_TYPE");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(255)
                .HasColumnName("WAREHOUSE");
        });

        modelBuilder.Entity<TmpItemBundle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ITEM_BUNDLE");

            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item).HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Qty).HasColumnName("QTY");
            entity.Property(e => e.SerialNo).HasColumnName("SERIAL_NO");
            entity.Property(e => e.SmItem).HasColumnName("SM_ITEM");
            entity.Property(e => e.SmRate).HasColumnName("SM_RATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify)
                .HasMaxLength(255)
                .HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpMedic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_MEDICS");

            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("Customer Name");
            entity.Property(e => e.F10).HasMaxLength(255);
            entity.Property(e => e.F9).HasMaxLength(255);
            entity.Property(e => e.MasterOrderId).HasColumnName("MasterOrder ID");
            entity.Property(e => e.NetAmount).HasColumnName("Net Amount");
            entity.Property(e => e.OrderDateAndTime)
                .HasMaxLength(255)
                .HasColumnName("Order Date and Time");
            entity.Property(e => e.OrderRefNo).HasColumnName("Order Ref No");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(255)
                .HasColumnName("Order Status");
            entity.Property(e => e.Remarks).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpNcareRider>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_NCARE_RIDERS");

            entity.Property(e => e.EmailIds)
                .HasMaxLength(255)
                .HasColumnName("Email IDs");
            entity.Property(e => e.F9).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.Mobile)
                .HasMaxLength(255)
                .HasColumnName("Mobile#");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.RiderDm).HasColumnName("Rider DM");
            entity.Property(e => e.RiderType)
                .HasMaxLength(255)
                .HasColumnName("Rider Type");
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<TmpNovoCanceled>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_novo_canceled");

            entity.Property(e => e.ApptakId)
                .HasMaxLength(255)
                .HasColumnName("APPTAK_ID");
            entity.Property(e => e.PspId)
                .HasMaxLength(255)
                .HasColumnName("PSP_ID");
        });

        modelBuilder.Entity<TmpNovoCancelled>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_NOVO_CANCELLED");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.Psporderid).HasColumnName("PSPORDERID");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<TmpNovoDelivered>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_novo_delivered");

            entity.Property(e => e.ApptakId)
                .HasMaxLength(255)
                .HasColumnName("APPTAK_ID");
            entity.Property(e => e.PspId)
                .HasMaxLength(255)
                .HasColumnName("PSP_ID");
        });

        modelBuilder.Entity<TmpNovoDispatched>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_NOVO_DISPATCHED");

            entity.Property(e => e.Distributor)
                .HasMaxLength(255)
                .HasColumnName("DISTRIBUTOR");
            entity.Property(e => e.Dsr)
                .HasMaxLength(255)
                .HasColumnName("DSR");
            entity.Property(e => e.DsrCode)
                .HasMaxLength(255)
                .HasColumnName("DSR_CODE");
            entity.Property(e => e.OrderId)
                .HasMaxLength(255)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(255)
                .HasColumnName("ORDER_STATUS");
        });

        modelBuilder.Entity<TmpNovoDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_NOVO_DSR");

            entity.Property(e => e.DsrCode)
                .HasMaxLength(255)
                .HasColumnName("DSR_CODE");
            entity.Property(e => e.Mobile).HasColumnName("Mobile#");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(255)
                .HasColumnName("Phone_No");
            entity.Property(e => e.RiderDsrCode)
                .HasMaxLength(255)
                .HasColumnName("Rider DSR CODE");
        });

        modelBuilder.Entity<TmpNovoOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_novo_orders");

            entity.Property(e => e.AgentName)
                .HasMaxLength(255)
                .HasColumnName("Agent Name");
            entity.Property(e => e.CityName)
                .HasMaxLength(255)
                .HasColumnName("City Name");
            entity.Property(e => e.DepotName)
                .HasMaxLength(255)
                .HasColumnName("Depot Name");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("Order Date");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(15)
                .HasColumnName("Order No");
            entity.Property(e => e.OrderType)
                .HasMaxLength(255)
                .HasColumnName("Order Type");
            entity.Property(e => e.PatientId)
                .HasMaxLength(255)
                .HasColumnName("Patient Id");
            entity.Property(e => e.Product).HasMaxLength(255);
            entity.Property(e => e.Remarks).HasMaxLength(255);
            entity.Property(e => e.RequiredBy)
                .HasColumnType("datetime")
                .HasColumnName("Required By");
        });

        modelBuilder.Entity<TmpNovoOrderStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_novo_order_status");

            entity.Property(e => e.ApptakOrderDate)
                .HasColumnType("datetime")
                .HasColumnName("APPTAK_ORDER_DATE");
            entity.Property(e => e.CashmemoDocDate)
                .HasColumnType("datetime")
                .HasColumnName("CASHMEMO_DOC_DATE");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.Distributor)
                .HasMaxLength(255)
                .HasColumnName("DISTRIBUTOR");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasColumnName("DOC_NO");
            entity.Property(e => e.Dsr)
                .HasMaxLength(255)
                .HasColumnName("DSR");
            entity.Property(e => e.DsrCode)
                .HasMaxLength(255)
                .HasColumnName("DSR_CODE");
            entity.Property(e => e.OrderId)
                .HasMaxLength(255)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.PspOrderId)
                .HasMaxLength(255)
                .HasColumnName("PSP_ORDER_ID");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
            entity.Property(e => e.UpdatedStatus).HasColumnName("UPDATED_STATUS");
        });

        modelBuilder.Entity<TmpNovoOrderStatus2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_novo_order_status_2");

            entity.Property(e => e.ApptakOrderDate)
                .HasColumnType("datetime")
                .HasColumnName("APPTAK_ORDER_DATE");
            entity.Property(e => e.CashmemoDocDate)
                .HasColumnType("datetime")
                .HasColumnName("CASHMEMO_DOC_DATE");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.Distributor)
                .HasMaxLength(255)
                .HasColumnName("DISTRIBUTOR");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasColumnName("DOC_NO");
            entity.Property(e => e.DsrCode)
                .HasMaxLength(255)
                .HasColumnName("DSR_CODE");
            entity.Property(e => e.F13).HasMaxLength(255);
            entity.Property(e => e.F3).HasMaxLength(255);
            entity.Property(e => e.OrderId)
                .HasMaxLength(255)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.PspOrderId).HasColumnName("PSP_ORDER_ID");
            entity.Property(e => e.PspStatus).HasColumnName("PSP_STATUS");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
            entity.Property(e => e.UpdatedStatus).HasColumnName("UPDATED_STATUS");
        });

        modelBuilder.Entity<TmpNovoReturned>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_novo_returned");

            entity.Property(e => e.MasterorderId)
                .HasMaxLength(255)
                .HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.OrderId)
                .HasMaxLength(255)
                .HasColumnName("order_id");
            entity.Property(e => e.PspId)
                .HasMaxLength(255)
                .HasColumnName("psp_id");
        });

        modelBuilder.Entity<TmpNovoRider>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_NOVO_RIDERS");

            entity.Property(e => e.DsrCode)
                .HasMaxLength(255)
                .HasColumnName("Dsr_Code");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(255)
                .HasColumnName("Phone_No");
        });

        modelBuilder.Entity<TmpNovoStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_novo_status");

            entity.Property(e => e.ApptakOrderId)
                .HasMaxLength(255)
                .HasColumnName("APPTAK_ORDER_ID");
            entity.Property(e => e.PspId).HasColumnName("PSP_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<TmpOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ORDERS");

            entity.Property(e => e.AglOrder)
                .HasMaxLength(255)
                .HasColumnName("AGL_ORDER");
            entity.Property(e => e.ApptakNum).HasColumnName("APPTAK_NUM");
            entity.Property(e => e.InvoiceNum)
                .HasMaxLength(255)
                .HasColumnName("INVOICE_NUM");
        });

        modelBuilder.Entity<TmpOrderCon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ORDER_CONS");

            entity.Property(e => e.ConsNum)
                .HasMaxLength(255)
                .HasColumnName("CONS_NUM");
            entity.Property(e => e.OrderId)
                .HasMaxLength(255)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.RrStatus)
                .HasMaxLength(255)
                .HasColumnName("RR Status");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<TmpOrderCons1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ORDER_CONS_1");

            entity.Property(e => e.ConsignmentNumber)
                .HasMaxLength(255)
                .HasColumnName("Consignment Number");
            entity.Property(e => e.CustomerSRefNo)
                .HasMaxLength(255)
                .HasColumnName("Customer's Ref No");
            entity.Property(e => e.RrStatus)
                .HasMaxLength(255)
                .HasColumnName("RR Status");
            entity.Property(e => e.SNo).HasColumnName("S#No#");
        });

        modelBuilder.Entity<TmpOrderCons2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ORDER_CONS_2");

            entity.Property(e => e.ConsignmentNum).HasMaxLength(255);
            entity.Property(e => e.EstoreOrderId)
                .HasMaxLength(255)
                .HasColumnName("estoreOrderId");
        });

        modelBuilder.Entity<TmpOrderCons3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ORDER_CONS_3");

            entity.Property(e => e.CnNo).HasColumnName("CN NO");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(255)
                .HasColumnName("partnerOrderId");
        });

        modelBuilder.Entity<TmpOrderCons4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ORDER_CONS_4");

            entity.Property(e => e.CnNo)
                .HasMaxLength(255)
                .HasColumnName("CN NO");
            entity.Property(e => e.PartnerOrderId)
                .HasMaxLength(255)
                .HasColumnName("partnerOrderId");
        });

        modelBuilder.Entity<TmpPharmaUpload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_PHARMA_UPLOAD");

            entity.Property(e => e.MasterSku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Master_SKU");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.SkuCode)
                .HasMaxLength(255)
                .HasColumnName("SKU_CODE");
        });

        modelBuilder.Entity<TmpRider>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_riders");

            entity.Property(e => e.Coverage).HasMaxLength(255);
            entity.Property(e => e.DepotCode).HasColumnName("Depot Code");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.LoginId)
                .HasMaxLength(255)
                .HasColumnName("Login ID");
            entity.Property(e => e.Mobile)
                .HasMaxLength(255)
                .HasColumnName("Mobile#");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.RiderDmDsrCode)
                .HasMaxLength(255)
                .HasColumnName("Rider DM DSR CODE");
            entity.Property(e => e.RiderType)
                .HasMaxLength(255)
                .HasColumnName("Rider Type");
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<TmpSghItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_SGH_ITEMS");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.SkuCategory)
                .HasMaxLength(255)
                .HasColumnName("SKU_CATEGORY");
            entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");
        });

        modelBuilder.Entity<TmpSghItem1807>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_sgh_item_1807");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.SghCode)
                .HasMaxLength(255)
                .HasColumnName("SGH_CODE");
        });

        modelBuilder.Entity<TmpSghItem20072024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_sgh_item_20072024");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode).HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.SkuCategory)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SKU_CATEGORY");
            entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");
            entity.Property(e => e.StockQtyEstore).HasColumnName("STOCK_QTY_ESTORE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<TmpSghItemF1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_sgh_item_f1");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode).HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.SkuCategory)
                .HasMaxLength(255)
                .HasColumnName("SKU_CATEGORY");
            entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");
            entity.Property(e => e.StockQtyEstore)
                .HasMaxLength(255)
                .HasColumnName("STOCK_QTY_ESTORE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<TmpSghItemFinal24>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_sgh_item_final_24");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(255)
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LastUpdated)
                .HasMaxLength(255)
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode).HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.SkuCategory)
                .HasMaxLength(255)
                .HasColumnName("SKU_CATEGORY");
            entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");
            entity.Property(e => e.StockQtyEstore)
                .HasMaxLength(255)
                .HasColumnName("STOCK_QTY_ESTORE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasMaxLength(255)
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<TmpSghItemNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_sgh_item_new");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(255)
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LastUpdated)
                .HasMaxLength(255)
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode).HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.SkuCategory)
                .HasMaxLength(255)
                .HasColumnName("SKU_CATEGORY");
            entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");
            entity.Property(e => e.StockQtyEstore)
                .HasMaxLength(255)
                .HasColumnName("STOCK_QTY_ESTORE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasMaxLength(255)
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<TmpSghItems200724>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_sgh_items_200724");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(255)
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LastUpdated)
                .HasMaxLength(255)
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.MnpChildItemCode)
                .HasMaxLength(255)
                .HasColumnName("MNP_CHILD_ITEM_CODE");
            entity.Property(e => e.MnpMasterItemCode).HasColumnName("MNP_MASTER_ITEM_CODE");
            entity.Property(e => e.SghSkuCode)
                .HasMaxLength(255)
                .HasColumnName("SGH_SKU_CODE");
            entity.Property(e => e.SkuCategory)
                .HasMaxLength(255)
                .HasColumnName("SKU_CATEGORY");
            entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");
            entity.Property(e => e.StockQtyEstore)
                .HasMaxLength(255)
                .HasColumnName("STOCK_QTY_ESTORE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasMaxLength(255)
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<TmpSghOrderRe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_sgh_order_res");

            entity.Property(e => e.TEstoreorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("t_estoreorderid");
            entity.Property(e => e.TStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("t_status");
        });

        modelBuilder.Entity<TmpSkuCe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_SKU_CE");

            entity.Property(e => e.SkuCode)
                .HasMaxLength(255)
                .HasColumnName("SKU_CODE");
        });

        modelBuilder.Entity<TmpZamCitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ZAM_CITEMS");

            entity.Property(e => e.ChItem)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.ChItemFullName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_FULL_NAME");
            entity.Property(e => e.ChItemShortName)
                .HasMaxLength(255)
                .HasColumnName("CH_ITEM_SHORT_NAME");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate).HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost)
                .HasMaxLength(255)
                .HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade)
                .HasMaxLength(255)
                .HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost)
                .HasMaxLength(255)
                .HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade)
                .HasMaxLength(255)
                .HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode).HasColumnName("REF_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpZamIcat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ZAM_ICAT");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ScatCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCAT_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<TmpZamMitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ZAM_MITEMS");

            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Delivery)
                .HasMaxLength(255)
                .HasColumnName("DELIVERY");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.F39).HasMaxLength(255);
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .HasColumnName("ITEM");
            entity.Property(e => e.Item1)
                .HasMaxLength(255)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item1Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM1_NAME");
            entity.Property(e => e.Item2)
                .HasMaxLength(255)
                .HasColumnName("ITEM2");
            entity.Property(e => e.Item2Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM2_NAME");
            entity.Property(e => e.Item3)
                .HasMaxLength(255)
                .HasColumnName("ITEM3");
            entity.Property(e => e.Item3Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM3_NAME");
            entity.Property(e => e.Item4)
                .HasMaxLength(255)
                .HasColumnName("ITEM4");
            entity.Property(e => e.Item4Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM4_NAME");
            entity.Property(e => e.Item5)
                .HasMaxLength(255)
                .HasColumnName("ITEM5");
            entity.Property(e => e.Item5Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM5_NAME");
            entity.Property(e => e.Item6)
                .HasMaxLength(255)
                .HasColumnName("ITEM6");
            entity.Property(e => e.Item6Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM6_NAME");
            entity.Property(e => e.Item7)
                .HasMaxLength(255)
                .HasColumnName("ITEM7");
            entity.Property(e => e.Item7Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM7_NAME");
            entity.Property(e => e.Item8)
                .HasMaxLength(255)
                .HasColumnName("ITEM8");
            entity.Property(e => e.Item8Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM8_NAME");
            entity.Property(e => e.Item9)
                .HasMaxLength(255)
                .HasColumnName("ITEM9");
            entity.Property(e => e.Item9Name)
                .HasMaxLength(255)
                .HasColumnName("ITEM9_NAME");
            entity.Property(e => e.ItemFullName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_FULL_NAME");
            entity.Property(e => e.ItemShortName)
                .HasMaxLength(255)
                .HasColumnName("ITEM_SHORT_NAME");
            entity.Property(e => e.ModifyDate)
                .HasMaxLength(255)
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.NewCost).HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade).HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost).HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade).HasColumnName("OLD_TRADE");
            entity.Property(e => e.RefCode).HasColumnName("REF_CODE");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(255)
                .HasColumnName("SELL_CATEGORY");
            entity.Property(e => e.Seller)
                .HasMaxLength(255)
                .HasColumnName("SELLER");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.UserEntry).HasColumnName("USER_ENTRY");
            entity.Property(e => e.UserModify).HasColumnName("USER_MODIFY");
        });

        modelBuilder.Entity<UniLever>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Uni_lever");

            entity.Property(e => e.Brand).HasMaxLength(255);
            entity.Property(e => e.ConsumerPrice).HasColumnName("Consumer Price");
            entity.Property(e => e.ConsumerPrice1).HasColumnName("Consumer Price1");
            entity.Property(e => e.DistMarginAge)
                .HasMaxLength(255)
                .HasColumnName("Dist# Margin (% age)");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("End Date");
            entity.Property(e => e.Gst).HasColumnName("GST");
            entity.Property(e => e.GstNregistered).HasColumnName("Gst_NRegistered");
            entity.Property(e => e.GstPrice).HasColumnName("Gst Price");
            entity.Property(e => e.GstRegistered).HasColumnName("Gst_Registered");
            entity.Property(e => e.NewMrsp).HasColumnName("New_MRSP");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(255)
                .HasColumnName("Product Code");
            entity.Property(e => e.ProductDescription)
                .HasMaxLength(255)
                .HasColumnName("Product Description");
            entity.Property(e => e.ProductStatus)
                .HasMaxLength(255)
                .HasColumnName("Product Status");
            entity.Property(e => e.PurchasePrice).HasColumnName("Purchase Price");
            entity.Property(e => e.PurchasePrice1).HasColumnName("Purchase Price1");
            entity.Property(e => e.SNo).HasColumnName("S No");
            entity.Property(e => e.TaxType)
                .HasMaxLength(255)
                .HasColumnName("Tax Type");
            entity.Property(e => e.TradePrice).HasColumnName("Trade Price");
            entity.Property(e => e.TradePrice1).HasColumnName("Trade Price1");
            entity.Property(e => e.UnitsInCase).HasColumnName("Units in Case");
        });

        modelBuilder.Entity<UplSku>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UPL_SKU");

            entity.Property(e => e.Brand).HasMaxLength(255);
            entity.Property(e => e.ConsumerPrice1).HasColumnName("Consumer Price1");
            entity.Property(e => e.MasterItem).HasColumnName("Master_Item");
            entity.Property(e => e.NewMrsp).HasColumnName("New_MRSP");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD_MRSP");
            entity.Property(e => e.ProductCode).HasColumnName("Product Code");
            entity.Property(e => e.ProductDescription)
                .HasMaxLength(255)
                .HasColumnName("Product Description");
            entity.Property(e => e.ProductStatus)
                .HasMaxLength(255)
                .HasColumnName("Product Status");
            entity.Property(e => e.PurchasePrice1).HasColumnName("Purchase Price1");
            entity.Property(e => e.SNo).HasColumnName("S No");
            entity.Property(e => e.TradePrice1).HasColumnName("Trade Price1");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Area)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Billing_address");
            entity.Property(e => e.Birthday)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("birthday");
            entity.Property(e => e.City)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Company_Code");
            entity.Property(e => e.Country)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate).HasColumnName("Joining_Date");
            entity.Property(e => e.Keydate)
                .HasColumnType("smalldatetime")
                .HasColumnName("keydate");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Postal_Code");
            entity.Property(e => e.Province)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ShippingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Shipping_address");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tempkey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tempkey");
            entity.Property(e => e.UserCode)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("User_code");
            entity.Property(e => e.UserCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Company_Name");
            entity.Property(e => e.UserCompanyNick)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_Company_nick");
            entity.Property(e => e.UserType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("User_type");
        });

        modelBuilder.Entity<UserAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User_Add__3214EC27306E7300");

            entity.ToTable("User_Address");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AddressIdentification)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Address_identification");
            entity.Property(e => e.Createdby).HasMaxLength(30);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber).HasMaxLength(30);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Organization_name");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .HasColumnName("UserID");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("zipCode");
        });

        modelBuilder.Entity<UserAssignPickuppoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("User_assign_Pickuppoint");

            entity.Property(e => e.Createdby).HasMaxLength(20);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("iD");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<UserCart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("User_Cart");

            entity.Property(e => e.ChildItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Child_Item");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.MasterItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Master_Item");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Unit_Price");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Entry");
        });

        modelBuilder.Entity<UserLoginAudit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("user_login_audit");

            entity.Property(e => e.LoginDt)
                .HasColumnType("datetime")
                .HasColumnName("login_dt");
            entity.Property(e => e.UserCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_code");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.WorkstationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workstation_id");
        });

        modelBuilder.Entity<UserPermission>(entity =>
        {
            entity.HasKey(e => new { e.CompanyCode, e.UserCode, e.ApiEndpointId }).HasName("PK__UserPerm__512E51E2B81872FA");

            entity.Property(e => e.CompanyCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Company_Code");
            entity.Property(e => e.UserCode)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("User_Code");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .HasColumnName("User_Email");

            entity.HasOne(d => d.ApiEndpoint).WithMany(p => p.UserPermissions)
                .HasForeignKey(d => d.ApiEndpointId)
                .HasConstraintName("FK__UserPermi__ApiEn__73B00EE2");

            entity.HasOne(d => d.TaUser).WithMany(p => p.UserPermissions)
                .HasForeignKey(d => new { d.CompanyCode, d.UserCode })
                .HasConstraintName("FK__UserPermissions__72BBEAA9");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("User_type");

            entity.Property(e => e.Createdby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserWishlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("User_Wishlist");

            entity.Property(e => e.ChildItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Child_Item");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.MasterItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Master_Item");
            entity.Property(e => e.UserEntry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("User_Entry");
        });

        modelBuilder.Entity<VendorOrder>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.OrderId, e.AccountId, e.ProdId, e.Status });

            entity.ToTable("VENDOR_ORDER");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.OrderId)
                .HasMaxLength(40)
                .HasColumnName("OrderID");
            entity.Property(e => e.AccountId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("AccountID");
            entity.Property(e => e.ProdId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prod_ID");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("STATUS");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Area_Name");
            entity.Property(e => e.BilledTo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILLED_TO");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Cnic)
                .HasMaxLength(30)
                .HasColumnName("CNIC");
            entity.Property(e => e.Codamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CODAmount");
            entity.Property(e => e.CodreferenceNo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CODReferenceNO");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Createdby).HasMaxLength(40);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.DeliveryCharges)
                .HasMaxLength(30)
                .HasColumnName("Delivery_Charges");
            entity.Property(e => e.GrossTotal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Gross_Total");
            entity.Property(e => e.ItemDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Item_Detail");
            entity.Property(e => e.ItemPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Item_Price");
            entity.Property(e => e.OType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("01")
                .HasColumnName("O_Type");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Purchaseon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quantity)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.ShippedTo)
                .HasMaxLength(50)
                .HasColumnName("SHIPPED_TO");
            entity.Property(e => e.ShippingCity).HasMaxLength(50);
            entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.TaUser).WithMany(p => p.VendorOrders)
                .HasForeignKey(d => new { d.Company, d.AccountId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VO_USER");
        });

        modelBuilder.Entity<VendorOrderLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VENDOR_ORDER_LOG");

            entity.Property(e => e.AccountId)
                .HasMaxLength(40)
                .HasColumnName("AccountID");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Area_Name");
            entity.Property(e => e.BilledTo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILLED_TO");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Cnic)
                .HasMaxLength(30)
                .HasColumnName("CNIC");
            entity.Property(e => e.Codamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CODAmount");
            entity.Property(e => e.CodreferenceNo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CODReferenceNO");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Createdby).HasMaxLength(40);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.DeliveryCharges)
                .HasMaxLength(30)
                .HasColumnName("Delivery_Charges");
            entity.Property(e => e.GrossTotal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Gross_Total");
            entity.Property(e => e.ItemDetail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Item_Detail");
            entity.Property(e => e.ItemPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Item_Price");
            entity.Property(e => e.OType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("O_Type");
            entity.Property(e => e.OrderId)
                .HasMaxLength(40)
                .HasColumnName("OrderID");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProdId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Prod_ID");
            entity.Property(e => e.Purchaseon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quantity)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.ShippedTo)
                .HasMaxLength(50)
                .HasColumnName("SHIPPED_TO");
            entity.Property(e => e.ShippingCity).HasMaxLength(50);
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VendorPrincipalDiscount>(entity =>
        {
            entity.HasKey(e => new { e.Company, e.Type, e.SchemeNo }).HasName("PK_VENDOR_PR_DISCOUNT");

            entity.ToTable("VENDOR_PRINCIPAL_DISCOUNT");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.SchemeNo).HasColumnName("SCHEME_NO");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.Item1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM2");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("STATUS");
            entity.Property(e => e.Vendor)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("VENDOR");

            entity.HasOne(d => d.TaUser).WithMany(p => p.VendorPrincipalDiscounts)
                .HasForeignKey(d => new { d.Company, d.Vendor })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VPD_USER");
        });

        modelBuilder.Entity<VendorPrincipalMapping>(entity =>
        {
            entity.HasKey(e => e.VendorPrincipalId);

            entity.ToTable("VENDOR_PRINCIPAL_MAPPING");

            entity.Property(e => e.VendorPrincipalId).HasColumnName("VENDOR_PRINCIPAL_ID");
            entity.Property(e => e.Item1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM1");
            entity.Property(e => e.Item2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM2");
            entity.Property(e => e.VendorUserCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_USER_CODE");
        });

        modelBuilder.Entity<VendorProductDiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VENDOR_PRODUCT_DISCOUNT");

            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Criteria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRITERIA");
            entity.Property(e => e.In)
                .IsUnicode(false)
                .HasColumnName("IN");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.Out)
                .IsUnicode(false)
                .HasColumnName("OUT");
            entity.Property(e => e.RdpAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("RDP_AMOUNT");
            entity.Property(e => e.SchemeNo).HasColumnName("SCHEME_NO");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type).HasColumnName("TYPE");

            entity.HasOne(d => d.VendorPrincipalDiscount).WithMany()
                .HasForeignKey(d => new { d.Company, d.Type, d.SchemeNo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PD_DISCOUNT");
        });

        modelBuilder.Entity<VpblImeiDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vpbl_IME__3214EC275B7D407E");

            entity.ToTable("vpbl_IMEI_data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.Imei1)
                .HasMaxLength(50)
                .HasColumnName("IMEI1");
            entity.Property(e => e.Imei2)
                .HasMaxLength(50)
                .HasColumnName("IMEI2");
            entity.Property(e => e.Make).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(100);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.WarrantyEnds).HasMaxLength(20);
            entity.Property(e => e.WarrantyStarts).HasMaxLength(20);
        });

        modelBuilder.Entity<WebsiteInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Website_info");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CnicNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CNIC_NO");
            entity.Property(e => e.CompanyAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMPANY_ADDRESS");
            entity.Property(e => e.CompanyCode)
                .ValueGeneratedOnAdd()
                .HasColumnName("COMPANY_CODE");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPANY_NAME");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Ntnno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTNNO");
            entity.Property(e => e.OwnerName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OWNER_NAME");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Strnno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STRNNO");
            entity.Property(e => e.WebsitName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Websit_NAME");
        });

        modelBuilder.Entity<XxAddArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_ADD_AREA");

            entity.Property(e => e.AreaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Area_ID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Area_Name");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.GpsCoordinates)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GPS_COORDINATES");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<XxAddCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_ADD_CITY");

            entity.Property(e => e.CityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("City_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name");
            entity.Property(e => e.CityNameTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name_Title");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<XxAddCountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_ADD_COUNTRY");

            entity.Property(e => e.CountryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Country_ID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Country_Name");
            entity.Property(e => e.CountryNameTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Country_Name_Title");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<XxAddProvince>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_ADD_PROVINCE");

            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.ProvinceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Province_ID");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Province_NAME");
            entity.Property(e => e.ProvinceNameTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Province_NAME_TITLE");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<XxCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_Company");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Area).HasMaxLength(4);
            entity.Property(e => e.City).HasMaxLength(4);
            entity.Property(e => e.CnicNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CNIC_NO");
            entity.Property(e => e.CompanyAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMPANY_ADDRESS");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(2)
                .HasColumnName("COMPANY_CODE");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPANY_NAME");
            entity.Property(e => e.Country).HasMaxLength(4);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.OwnerName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OWNER_NAME");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO");
            entity.Property(e => e.Province).HasMaxLength(4);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.WebsitName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Websit_NAME");
        });

        modelBuilder.Entity<XxMasterOrder20191129>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_master_order_20191129");

            entity.Property(e => e.AddressType).HasColumnName("ADDRESS_TYPE");
            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.MasterorderDate).HasColumnName("MASTERORDER_DATE");
            entity.Property(e => e.MasterorderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(40)
                .HasColumnName("Order_RefNo");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<XxMasterOrder20191204>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_master_order_20191204");

            entity.Property(e => e.AddressType).HasColumnName("ADDRESS_TYPE");
            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.MasterorderDate).HasColumnName("MASTERORDER_DATE");
            entity.Property(e => e.MasterorderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(40)
                .HasColumnName("Order_RefNo");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<XxMasterOrder26112019>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_MASTER_ORDER_26112019");

            entity.Property(e => e.AddressType).HasColumnName("ADDRESS_TYPE");
            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.MasterorderDate).HasColumnName("MASTERORDER_DATE");
            entity.Property(e => e.MasterorderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(40)
                .HasColumnName("Order_RefNo");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<XxOrderDetail20191125>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_ORDER_detail_20191125");

            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.ChItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CH_ITEM");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.MrspNew)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("MRSP_NEW");
            entity.Property(e => e.MrspOld)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("MRSP_OLD");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.PrecriptionImg).HasColumnName("PRECRIPTION_IMG");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SELL_CATEGORY");
        });

        modelBuilder.Entity<XxOrderHead20191125>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_ORDER_HEAD_20191125");

            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.DelvDate).HasColumnName("DELV_DATE");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ORDER_STATUS");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
        });

        modelBuilder.Entity<XxOrderHead20191129>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_ORDER_HEAD_20191129");

            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.DelvDate).HasColumnName("DELV_DATE");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ORDER_STATUS");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
        });

        modelBuilder.Entity<XxOrderHead20191216>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_order_head_20191216");

            entity.Property(e => e.Adiscount1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT1");
            entity.Property(e => e.Adiscount2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT2");
            entity.Property(e => e.Adiscount3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ADISCOUNT3");
            entity.Property(e => e.Company)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COMPANY");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDON");
            entity.Property(e => e.DeliveryCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DELIVERY_CHARGES");
            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_MODE");
            entity.Property(e => e.DelvDate).HasColumnName("DELV_DATE");
            entity.Property(e => e.Depotcode).HasColumnName("DEPOTCODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.MasterorderId).HasColumnName("MASTERORDER_ID");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MOBILENO");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDON");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OrderDate).HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ORDER_STATUS");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SAddress1)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS1");
            entity.Property(e => e.SAddress2)
                .IsUnicode(false)
                .HasColumnName("S_ADDRESS2");
            entity.Property(e => e.SArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_AREA");
            entity.Property(e => e.SCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CITY");
            entity.Property(e => e.SCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_COUNTRY");
            entity.Property(e => e.SFullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_FULLNAME");
            entity.Property(e => e.SProvince)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("S_PROVINCE");
            entity.Property(e => e.SZipcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ZIPCODE");
        });

        modelBuilder.Entity<XxProdHeirarchyUpl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_Prod_Heirarchy_UPL");

            entity.Property(e => e.Item).HasMaxLength(255);
            entity.Property(e => e.Prod1).HasColumnName("PROD1");
            entity.Property(e => e.Prod1Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD1_DESC");
            entity.Property(e => e.Prod2).HasColumnName("PROD2");
            entity.Property(e => e.Prod2Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD2_DESC");
            entity.Property(e => e.Prod3)
                .HasMaxLength(255)
                .HasColumnName("PROD3");
            entity.Property(e => e.Prod3Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD3_DESC");
            entity.Property(e => e.Prod4)
                .HasMaxLength(255)
                .HasColumnName("PROD4");
            entity.Property(e => e.Prod4Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD4_DESC");
            entity.Property(e => e.Prod5)
                .HasMaxLength(255)
                .HasColumnName("PROD5");
            entity.Property(e => e.Prod5Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD5_DESC");
            entity.Property(e => e.Prod6)
                .HasMaxLength(255)
                .HasColumnName("PROD6");
            entity.Property(e => e.Prod6Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD6_DESC");
            entity.Property(e => e.Prod7)
                .HasMaxLength(255)
                .HasColumnName("PROD7");
            entity.Property(e => e.Prod7Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD7_DESC");
            entity.Property(e => e.Prod8)
                .HasMaxLength(255)
                .HasColumnName("PROD8");
            entity.Property(e => e.Prod8Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD8_DESC");
            entity.Property(e => e.Prod9)
                .HasMaxLength(255)
                .HasColumnName("PROD9");
            entity.Property(e => e.Prod9Desc)
                .HasMaxLength(255)
                .HasColumnName("PROD9_DESC");
            entity.Property(e => e.ProdCode)
                .HasMaxLength(255)
                .HasColumnName("PROD_CODE");
            entity.Property(e => e.ProdDesc)
                .HasMaxLength(255)
                .HasColumnName("PROD_DESC");
            entity.Property(e => e.ProdStatus)
                .HasMaxLength(255)
                .HasColumnName("PROD_STATUS");
        });

        modelBuilder.Entity<XxScotchBright3m>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_Scotch_bright_3M");

            entity.Property(e => e.AccountGroup)
                .HasMaxLength(255)
                .HasColumnName("ACCOUNT_GROUP");
            entity.Property(e => e.ActCode)
                .HasMaxLength(255)
                .HasColumnName("ACT_CODE");
            entity.Property(e => e.Breadth).HasColumnName("BREADTH");
            entity.Property(e => e.Carton1).HasColumnName("CARTON1");
            entity.Property(e => e.Carton2).HasColumnName("CARTON2");
            entity.Property(e => e.Carton3).HasColumnName("CARTON3");
            entity.Property(e => e.Carton4).HasColumnName("CARTON4");
            entity.Property(e => e.CompleteStop)
                .HasMaxLength(255)
                .HasColumnName("COMPLETE_STOP");
            entity.Property(e => e.Gst).HasColumnName("GST");
            entity.Property(e => e.Hieght).HasColumnName("HIEGHT");
            entity.Property(e => e.Lenght).HasColumnName("LENGHT");
            entity.Property(e => e.MajorStop)
                .HasMaxLength(255)
                .HasColumnName("MAJOR_STOP");
            entity.Property(e => e.MiniStop)
                .HasMaxLength(255)
                .HasColumnName("MINI_STOP");
            entity.Property(e => e.NewCost).HasColumnName("NEW_COST");
            entity.Property(e => e.NewMrsp).HasColumnName("NEW MRSP ");
            entity.Property(e => e.NewMrsp1).HasColumnName("NEW_MRSP");
            entity.Property(e => e.NewTrade).HasColumnName("NEW_TRADE");
            entity.Property(e => e.OldCost).HasColumnName("OLD_COST");
            entity.Property(e => e.OldMrsp).HasColumnName("OLD MRSP");
            entity.Property(e => e.OldMrsp1).HasColumnName("OLD_MRSP");
            entity.Property(e => e.OldTrade).HasColumnName("OLD_TRADE");
            entity.Property(e => e.PrdCode)
                .HasMaxLength(255)
                .HasColumnName("PRD_CODE");
            entity.Property(e => e.PrdCode1)
                .HasMaxLength(255)
                .HasColumnName("PRD_CODE1");
            entity.Property(e => e.PrdGroup)
                .HasMaxLength(255)
                .HasColumnName("PRD_GROUP");
            entity.Property(e => e.PrdName)
                .HasMaxLength(255)
                .HasColumnName("PRD_NAME");
            entity.Property(e => e.PrdSize)
                .HasMaxLength(255)
                .HasColumnName("PRD_SIZE");
            entity.Property(e => e.STax1).HasColumnName("S_TAX1");
            entity.Property(e => e.STax2).HasColumnName("S_TAX2");
            entity.Property(e => e.STax3).HasColumnName("S_TAX3");
            entity.Property(e => e.SalesGroup)
                .HasMaxLength(255)
                .HasColumnName("SALES_GROUP");
            entity.Property(e => e.StorageCondition)
                .HasMaxLength(255)
                .HasColumnName("STORAGE_CONDITION");
            entity.Property(e => e.TheropaticGroup).HasColumnName("THEROPATIC_GROUP");
        });

        modelBuilder.Entity<XxSellCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sell_Cat__3214EC270CC4257E");

            entity.ToTable("xx_Sell_Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SellCategory)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Sell_Category");
            entity.Property(e => e.SellCategoryId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Sell_CategoryID");
        });

        modelBuilder.Entity<XxSubChildTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_sub_child_Test");

            entity.Property(e => e.ChildId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("child_id");
            entity.Property(e => e.MenuIconClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("menu_icon_class");
            entity.Property(e => e.ParentId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("parent_id");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubchildDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Subchild_desc");
            entity.Property(e => e.SubchildId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Subchild_id");
            entity.Property(e => e.SubchildUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Subchild_url");
        });

        modelBuilder.Entity<XxTaUsers02122019>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx_ta_Users02122019");

            entity.Property(e => e.Area)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Billing_address");
            entity.Property(e => e.Birthday)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("birthday");
            entity.Property(e => e.City)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .HasColumnName("cnic");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Company_Code");
            entity.Property(e => e.Country)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.DateEntry).HasColumnName("Date_Entry");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate).HasColumnName("Joining_Date");
            entity.Property(e => e.Keydate)
                .HasColumnType("smalldatetime")
                .HasColumnName("keydate");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Modified_By");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("Modified_on");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Postal_Code");
            entity.Property(e => e.Province)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ShippingAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Shipping_address");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tempkey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tempkey");
            entity.Property(e => e.UserCode)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("User_code");
            entity.Property(e => e.UserCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Company_Name");
            entity.Property(e => e.UserCompanyNick)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_Company_nick");
            entity.Property(e => e.UserType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("User_type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
