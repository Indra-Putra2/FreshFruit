# Fresh Fruit
 
 ### Functionality
- dapat menambahkan buah apel kedalam keranjang
- dapat menambahkan buah pisang kedalam keranjang
- dapat menambahkan buah jeruk kedalam keranjang
- dapat menambahkan buah anggur kedalam keranjang

### Tugas
1. Apakah fungsi BucketEventListener?
- digunakan untuk menampilkan pesan ketika fungsi void ```onSucceed(string massage)``` atau 
```void onFailed(string massage)``` dipanggil

2. Class diagram

![Diagram](FreshFruit/Assets/Class%20Diagram.jpg)

3. Berilah pembahasan alur atau logika pemrogramannya
- ketika button add di klik fungsi ```public void addFruit``` dipanggil kemudian mengecek apakah 
```public Bucket(int capacity)``` penuh atau tidak jika penuh maka fungsi ```bucketIsOverLoad``` 
dipanggil dan akan menampilkan pesan "Ops, Keranjang Penuh" jika belum penuh maka fungsi 
```this.bucket.insert(fruit)``` dipanggil dan menampilkan pesan "Yey, Berhasil di tambahkan"
