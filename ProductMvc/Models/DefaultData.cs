using System.Collections.Generic;
using System.Data.Entity;

namespace ProductMvc.Models
{
    //public class DefaultData : DropCreateDatabaseIfModelChanges<VinaEntity>
    //{
    //    protected override void Seed(VinaEntity context)
    //    {
    //        #region Tạo dữ liệu User quản trị ( hỗ trợ mã hóa mật khẩu MD5)
    //        // Tên đăng nhập admin , pass : 123456 ( tương ứng với mã MD5 là e10adc3949ba59abbe56e057f20f883e
    //        new List<User> {
    //        new User{ UserName="admin",Password="e10adc3949ba59abbe56e057f20f883e"}
    //        }.ForEach(m => context.Users.Add(m));
    //        #endregion


    //        #region Tạo danh sách tầng
    //        new List<Floor> {
    //        new Floor { FloorId=1,FloorName="Tầng 1"},       
    //        new Floor { FloorId=2,FloorName="Tầng 2"},         
    //        new Floor { FloorId=3,FloorName="Tầng 3"}    
    //                   }.ForEach(m => context.Floors.Add(m));
    //        #endregion
    //        #region danh sách phòng
    //        new List<Room> { 
    //        new Room {RoomId=101,RoomName ="Phòng 102",FloorId=1,IsDouble=true},
    //        new Room {RoomId=102,RoomName ="Phòng 103",FloorId=1,IsDouble=true},
    //        new Room {RoomId=103,RoomName ="Phòng 104",FloorId=1,IsDouble=true},
    //        new Room {RoomId=200,RoomName ="Phòng 200",FloorId=2,IsDouble=false},
    //        new Room {RoomId=201,RoomName ="Phòng 201",FloorId=2,IsDouble=false},
    //        new Room {RoomId=202,RoomName ="Phòng 202",FloorId=2,IsDouble=true},
    //        new Room {RoomId=203,RoomName ="Phòng 203",FloorId=2,IsDouble=true},
    //        new Room {RoomId=204,RoomName ="Phòng 204",FloorId=2,IsDouble=false},
    //        new Room {RoomId=205,RoomName ="Phòng 205",FloorId=2,IsDouble=true},
    //        new Room {RoomId=300,RoomName ="Phòng 300",FloorId=3,IsDouble=false},
    //        new Room {RoomId=301,RoomName ="Phòng 301",FloorId=3,IsDouble=false},
    //        new Room {RoomId=302,RoomName ="Phòng 302",FloorId=3,IsDouble=false},
    //        new Room {RoomId=303,RoomName ="Phòng 303",FloorId=3,IsDouble=false},
    //        new Room {RoomId=304,RoomName ="Phòng 304",FloorId=3,IsDouble=false},
    //        new Room {RoomId=305,RoomName ="Phòng 305",FloorId=3,IsDouble=false},
    //        }.ForEach(m => context.Rooms.Add(m));
    //        #endregion

    //        #region danh sách dịch vụ khác
    //        new List<OtherService> { 
    //        new OtherService {OtherServiceId=1,ServiceName ="Nước suối",Price=10000},
    //        new OtherService {OtherServiceId=2,ServiceName ="Nước ngọt",Price=10000},
    //        new OtherService {OtherServiceId=3,ServiceName ="Bò húc",Price=15000},
    //        new OtherService {OtherServiceId=4,ServiceName ="Bia 333",Price=15000},
    //        new OtherService {OtherServiceId=5,ServiceName ="Heniken",Price=25000}
    //        }.ForEach(m => context.OtherServices.Add(m));
    //        #endregion
    //        #region danh sách giá dịch vụ phòng
    //        new List<RoomServicePrice> { 
    //        new RoomServicePrice {Minutes=65,Price=50000,RoomServiceType=0},
    //        new RoomServicePrice {Minutes=80,Price=10000,RoomServiceType=0},
    //        new RoomServicePrice {Minutes=120,Price=10000,RoomServiceType=0},
    //        new RoomServicePrice {Minutes=180,Price=10000,RoomServiceType=0},
    //        new RoomServicePrice {Minutes=1,Price=150000,RoomServiceType=1},
    //        new RoomServicePrice {Minutes=1,Price=250000,RoomServiceType=2}
    //        }.ForEach(m => context.RoomServicePrices.Add(m));
    //        #endregion
    //        #region config
    //        new List<Config> { 
    //        new Config {Key="OverTimeAllow",Value="15"}
    //        }.ForEach(m => context.Configs.Add(m));
    //        #endregion

    //    }

    //}
}