# Giới Thiệu

## Tên Dự Án

- Another UEH

## Mô Tả Ngắn Gọn

- Dự án game 3D được tạo bằng Unity và được code bằng C#. Mục tiêu của dự án là hoàn thành bài đồ án cuối kỳ cho một học phần.

## Mục Đích Dự Án

- Tạo ra một trò chơi nhằm đáp ứng yêu cầu đồ án cuối kỳ.

## Nhóm Phát Triển

Gồm 6 thành viên:

- Nguyễn Hoàng Minh Tấn (Trưởng Nhóm)

- Đoàn Thanh Lâm

- Dương Lâm Gia Kiệt

- Phạm Trung

- Nguyễn Tuấn Dũng

- Đỗ Trọng Hiếu

## Công Nghệ Sử Dụng

- Unity 2022.3.18f1

- Ngôn ngữ lập trình: C#

# Cốt Truyện

- Tựa game bắt đầu với một cô sinh viên tên Nozomi vô tình lạc vào các cơ sở của UEH ở một thế giới khác. Cô được chọn làm một Breaker, được dẫn dắt bởi Instructor với mục tiêu đánh bại Wanderer King để giải phóng những người bị mắc kẹt trong thế giới này và trở về nhà.

# Hạn Chế
- Xây dựng màn chơi, triển khai cốt truyện và hệ thống chiến đấu vì giới hạn thời gian của đồ án cuối kỳ nên không thể nào đạt được sự chỉnh chu cần thiết.

- Thêm nữa là các Wanderer là những thực thể đại diện cho các sinh viên mất đi định hướng và bị tha hóa bởi sức mạnh từ thế giới đó. Ngoại hình của họ cơ bản là hình người nhưng với vẻ ngoài kỳ dị. Tuy nhiên, trong quá trình phát triển dự án, nhóm quyết định đổi ngoại hình của Wanderer từ hình người thành khủng long.

## Hướng Dẫn Cài Đặt

# Yêu Cầu Hệ Thống

- Unity Hub

- Unity phiên bản 2022.3.18f1

- VS Studio 2022

# Cài Đặt

#### Start. Tải file .rar NOZ_C
    Đường dẫn: https://drive.google.com/drive/folders/12ctnRe4-bT7su7J_1JZy7RaiY3Re6pX1?usp=drive_link
#### 1. Kết nối database:
- Mở server explorer, chuột phải vào Data Connection chọn "Add Connection", thay đổi Data Source thành "Microsoft SQL Server Database File". Database file name --> Chọn Browse, ở thư mục AdminLogin, chọn Database1.mdf.
#### 2. Sửa connectionString
-  Mở properties của database, sao chép connectionString (chỉ lấy tới "Integrated Security=True"), sửa nó ở file DangNhap.cs và Connection.cs
#### 3. Sửa jsonFilePath - dòng 60 - trong DangNhap.cs 
- Vào đến đường dẫn "...\AdminLogin\bin\Debug" trong máy của bạn, sao chép "...\AdminLogin\bin\Debug" và sửa lại "C:\Users\84967\OneDrive\Documents\GitHub\Another_UEH_2\AdminLogin\bin\Debug" trong file gốc (Lưu ý \AnotherUEHSaveFile phải giữ nguyên)
#### 4. Sửa đường dẫn mở file .exe - dòng 85 - trong DangNhap.cs của game
- Mở Unity Hub rồi mở dự án NOZ_C mới tải về (nhớ chọn đúng phiên bản 2022.3.18f1), vào file ==> Chọn Build Settings ==> Click hết tất cả các scene trong Scenes in build ==> Platform chọn window/mac/linux ==> Chọn Build ==> Lưu ở chỗ bạn muốn
- Copy đường link file NOZ_C .exe bạn mới tạo ở trên, sửa lại phần "C:\Users\84967\Downloads\UEH_GAME"
#### 5. Xóa thư mục bin và obj ở trong thư mục AdminLogin rồi build lại dự án và chạy (đến khi xuất hiện lại 2 thư mục bin và obj)
#### 6. Thêm file AnotherUEHSaveFile trong thư mục Additional_SaveFile vào trong /bin/Debug 
#### 7. Mở file AdminLogin.exe trong /bin/Debug
- Đăng nhập băng tài khoản sau:
    * TK: duongtank1
    * MK: duongtank
- Click chuột chọn đăng nhập, ấn ok là bắt đầu vào đây.
## Hướng Dẫn Chơi
- Di chuyển bằng hai nút A và D.
- Đánh bằng J, né bằng K.
- Tương tác bằng F.
- Ấn nút ESC. Ở đây bạn dùng chuột chọn tăng cấp hoặc Settings. Trong Settings bạn có thể chỉnh âm thanh và thoát (nút Exit).
