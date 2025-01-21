# Dự án SOA_BT1

## Giới thiệu
Dự án này là một ứng dụng minh họa mô hình kiến trúc dịch vụ (Service-Oriented Architecture - SOA). Hệ thống bao gồm hai phần chính: **Server** (Web Service) và **Client** (Ứng dụng giao diện người dùng) với các chức năng tương tác với cơ sở dữ liệu về thông tin quốc gia và thành phố.

---

## Thành phần chính

### 1. **Server**
Server được phát triển với công nghệ **ASP.NET Web Service**, cung cấp các API hỗ trợ truy vấn cơ sở dữ liệu.

#### Các API chính:
1. **GreetWorld()**  
   - Trả về chuỗi "Hello World".

2. **GetCountries()**  
   - Lấy danh sách các quốc gia (giới hạn 50 quốc gia).

3. **GetCountryByCode(string code)**  
   - Lấy thông tin quốc gia dựa vào mã quốc gia.

4. **GetCitiesByName(string name)**  
   - Lấy danh sách các thành phố dựa vào tên.

5. **GetCitiesByCountry(string countryName)**  
   - Lấy danh sách thành phố thuộc quốc gia cụ thể.

6. **PopulationOfCountry(string countryName)**  
   - Trả về dân số của một quốc gia.

7. **GetCityByPopulation(int minPopulation, int maxPopulation)**  
   - Lấy danh sách các thành phố với dân số nằm trong khoảng chỉ định.

8. **OfficialLanguagesOfCountries(string countryCode)**  
   - Lấy danh sách các ngôn ngữ chính thức của quốc gia dựa vào mã quốc gia.

---

### 2. **Client**
Client là ứng dụng Windows Forms, cho phép người dùng tương tác với các dịch vụ được cung cấp bởi Server.

#### Tính năng chính:
- **Hiển thị danh sách quốc gia**.
- **Tìm quốc gia theo mã quốc gia**.
- **Xem dân số quốc gia**.
- **Xem danh sách thành phố theo quốc gia**.
- **Tìm thành phố theo tên**.
- **Lọc thành phố theo khoảng dân số**.
- **Xem ngôn ngữ chính thức của quốc gia**.

#### Xử lý ngoại lệ:
- Thông báo lỗi khi không nhập đúng dữ liệu đầu vào.
- Hiển thị thông báo khi không có dữ liệu trả về.

---

## Kết quả đạt được
- **Server hoạt động ổn định**, cung cấp các API truy vấn cơ sở dữ liệu một cách chính xác.
- **Client hoàn chỉnh**, với giao diện trực quan và dễ sử dụng để gọi các dịch vụ từ Server.
- **Cơ sở dữ liệu MyWorldEntities** được tích hợp, hỗ trợ truy vấn thông tin về quốc gia và thành phố.

---

## Hướng dẫn sử dụng
1. **Chạy Server**: Khởi động Web Service trong môi trường Visual Studio.
2. **Chạy Client**: Xây dựng và chạy ứng dụng Windows Forms, kết nối với Web Service.
3. Sử dụng các nút chức năng trên Client để gọi các dịch vụ tương ứng.

---

## Yêu cầu hệ thống
- .NET Framework 4.5 hoặc mới hơn.
- SQL Server để chạy cơ sở dữ liệu MyWorldEntities.

---
