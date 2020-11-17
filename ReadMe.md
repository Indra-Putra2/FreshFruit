# Fresh Fruit
 aplikasi sederhana yg fungsinya mensimulasikan pengambilan atau penambahan buah ke keranjang.
 
 ### Functionality
- menambahkan item kedalam keranjang
- dapat melihat gambar
- dapat mengklik tombol

### Tugas
1. Apakah fungsi BucketEventListener?
- digunakan untuk menampilkan pesan ketika fungsi ```onSucceed``` atau 
```onFailed``` dipanggil

2. Class diagram

![Diagram](FreshFruit/Assets/Class%20Diagram.jpg)

3. Berilah pembahasan alur atau logika pemrogramannya
- ketika button add di klik fungsi ```public void addFruit``` dipanggil kemudian mengecek apakah 
```public Bucket(int capacity)``` penuh atau tidak jika penuh maka fungsi ```bucketIsOverLoad``` 
dipanggil dan akan menampilkan pesan "Ops, Keranjang Penuh" jika belum penuh maka fungsi 
```this.bucket.insert(fruit)``` dipanggil dan menampilkan pesan "Yey, Berhasil di tambahkan"
