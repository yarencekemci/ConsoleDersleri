-- normalizasyon
-- Tablo oluşturma, normalizasyon , PK, FK

-- yaren
/*
Hastalar
Branşlar
Klinikler
Doktorlar
Personeller
Kullanıcılar
Yetkiler
Randevular

Id- Identity, Kimlik

Normalizasyom Kuralları
1-Sonsuz=> bağlanan 2 tablodan, bir tabloda tek bir data diğer tabloda birden fazla datayla eşitleniyorsa gerçekleşir
Sonsuz-1=>""
1-1=> 2 tablodan PK ile bağlanılır, her bir dataya tek data eşitlenir
Sonsuza-Sonsuz => 2 tablo ile yapılmaz 3 tablo olmalı. 1. tablo ve 3.tablo ,2. tabloya sonsuz sonsuz bağlanır

*/
