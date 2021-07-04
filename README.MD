<details>
<summary> Blog </summary>

Entity framework **CodeFirst** yaklaşımı ile geliştirildi <br>
Makale ekleme, silme, güncelleme ve listeleme yapılabiliyor

</details>

---

<details>
<summary> Blog - CleanArchitecture </summary>

Daha önce yapılmış olan blog projesi katmanlı mimari ile yeniden yapıldı<br>
Clean Architecture'ın Onion mimarisi yapılmaya çalışıldı<br>
Ayrıca Microsoft'un Identity kütüphanesi ile **Authorization** ve **Authentication** yönetimi yapıldı

</details>

---

<details>
<summary>CookiesNSession</summary>

# CookiesNSession
Cookies ve session kullanımını pekiştirmek için yapılan uygulama

## İstenenler
<strike>1 - Kitap ekleme ve listeleme yapılacak</strike><br>
<strike>2 - Eklenen kitaplar Session da tutulacak</strike><br>
3 - Listelenen kitaplar arasından favori kitap seçilebilecek<br>
<strike>4 - Seçilen favori kitap Cookies de tutulacak</strike><br>
- cookies'e kitap ekleme kodları yazıldı ama button ile actiona yönlendirme yapılamadı

</details>

---

<details>
<summary> ETicaret </summary>

Bootcamp boyunca öğrendiğimiz tüm konuları kullanarak geliştirildi<br>

</details>

---

<details>
<summary> KullaniciGirisSistemi</summary>

# KullaniciGirisSistemi
Session kavramını anlamak için yaptığım uygulama

## Controllers

- AuthController: 
	- Login(Get): Kullanıcı girişi sayfasını açar.
	- Login(Post): Girilen Kullanıcıyı kontrol eder, Sessionda oluşturulmuş olan kullanıcılar listesinde girilen kullanıcıyı arar, var ise CurrentUser'a girilen kullanıcıyı atar ve oturum açılmış olur.
	- Logout: Sessiondaki currentUser'ı siler. Böylelikle mevcut kullanıcı olmadığından oturum kapatılmış olur.

- HomeController: Içerisinde Index ve private actionları var. index actionu eğer kullanıcı girişi yapılmamışsa **(** *session'da currentUser yok ise* **)** AuthController'ın login actionuna yönlendiriyor. Sessionda *currentUser* var ise modele atıp Index view'ini açıyor.

- InitController:  Runtime da kullanıcı oluşturmak için oluşturduk. İçerisinde sadece index action'u var. Database yerine kullanıcıları sessiona atadığımız yer burası. Home controller'in index action'una yönlendiriyor.

## Views

- Auth -> login: Kullanıcı adı ve parola girişi yapılıyor, girilen kullanıcı bulunamazsa **viewbag** ile gelen kullanıcı bulunamadı hatasını label etiketine yazar

- Home -> Index'te Mevcut kullanıcı adını ve şifreyi gösteriyor. Bu bilgiler model aracılığıyla geliyor. Auth controller'ın logout action'una yönlendiren bir buton var.

</details>

---

<details>
<summary> KullaniciGirisSistemi</summary>

Session ile kullanıcı girişi yönetildi.
</details>