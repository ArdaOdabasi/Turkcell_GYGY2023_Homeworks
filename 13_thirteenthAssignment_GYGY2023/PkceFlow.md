# PKCE Flow ve PKCE Flow'ın ASP.NET MVC'de Kullanımı

# Giriş

PKCE (Proof Key for Code Exchange) Flow, OAuth 2.0 protokolünün güvenli bir varyasyonudur ve güvenli bir şekilde kimlik doğrulaması yapmak için kullanılır. Özellikle mobil uygulamalar ve tek sayfalı uygulamalar gibi güvenli olmayan ortamlarda kullanılan PKCE Flow, Authorization Code Flow'un zayıf noktalarını gidermek için geliştirilmiştir. Bu yazıda, PKCE Flow'un ne olduğunu, nasıl çalıştığını ve ASP.NET MVC projelerinde nasıl kullanıldığını detaylı bir şekilde inceleyeceğiz.

# PKCE Flow Nedir?

PKCE Flow, OAuth 2.0 protokolündeki Authorization Code Flow'un güvenli bir varyasyonudur. OAuth 2.0 protokolü, kullanıcıyı bir hizmete yetkilendirmek için kimlik sağlamasına dayanan bir protokoldür. Ancak, Authorization Code Flow, özellikle mobil ve tek sayfalı uygulamalar gibi güvenli olmayan ortamlarda güvenlik zafiyetlerine neden olabilir. PKCE Flow, bu zafiyetleri gidermek için geliştirilmiş bir ek güvenlik mekanizmasıdır.

PKCE Flow, Authorization Code Flow'a bir öncel adım ekleyerek çalışır. Bu öncel adımda, istemci (client) tarafından rastgele bir dize üretilir ve bu dizeye "code verifier" denir. Code verifier daha sonra özetlenerek "code challenge" oluşturulur. İstemci, code challenge'ı authorization isteği sırasında sunucuya gönderir ve authorization code almak için normal Authorization Code Flow işlemi başlatılır. Daha sonra authorization code kullanılarak erişim token'ı alınır.

PKCE Flow'un temel amacı, authorization code'ları rastgele bir dizeyle koruyarak saldırılara karşı daha güvenli bir kimlik doğrulama mekanizması sağlamaktır.

# PKCE Flow'un Çalışma Mekanizması

PKCE Flow, Authorization Code Flow'a bir güvenlik katmanı ekleyerek çalışır. Aşağıda PKCE Flow'un çalışma mekanizması adımlarıyla açıklanmaktadır:

1-) İstemci (client) tarafında rastgele bir dize olan "code verifier" üretilir.

2-) Code verifier, daha sonra SHA-256 veya SHA-512 gibi bir algoritma kullanılarak özetlenerek "code challenge" oluşturulur.

3-) İstemci, authorization isteği yaparken code challenge'ı ve diğer gerekli parametreleri (kapsam, geri dönüş URL'si, istemci kimliği vb.) gönderir.

4-) Authorization sunucusu, code challenge'ı ve diğer parametreleri doğrular ve authorization code'la birlikte geri dönüş yapar.

5-) İstemci, aldığı authorization code'ı kullanarak authorization sunucusundan erişim token'ı alır.

6-) İstemci, aldığı erişim token'ı kullanarak API isteklerini yetkilendirir.

![image](https://github.com/ArdaOdabasi/Turkcell_GYGY2023_Homeworks/assets/61662021/aede0020-5bde-4c46-9ec0-606f8fa50c41)

Yukarıdaki örneği düşünelim. Yasal uygulama, bir yetkilendirme isteği başlatacak ve Yetkilendirme sunucusu başarılı kimlik doğrulama sonrasında Yetkilendirme kodunu yanıt olarak gönderecektir. Burada, kötü niyetli uygulama, yasal uygulama ile aynı özel URI'ye (yönlendirme URI'si) kaydedilmiştir. Şimdi, kötü niyetli uygulama erişim belirteci alacak ve bunu bir erişim belirteci için takas edecektir. Şimdi, bu uygulama korunan kaynaklara erişim elde edecektir.

PKCE, yukarıda bahsedilen Yetkilendirme kodunun yanlış kullanım sorununu çözebilir. PKCE, akışta code_verifier, code_challenge ve code_challenge kullanır.

* code_verifier: 43 ile 128 karakter arasında rastgele bir dizedir.

* code_challenge: code_verifier'ın SHA256 ile özetlenerek elde edilen karma değerin base64 URL kodlamasıdır.

* code_challenge: Plain veya S256 olabilir.

# PKCE Flow'un ASP.NET MVC'de Kullanımı

PKCE Flow'u ASP.NET MVC projelerinde kullanmak için aşağıdaki adımları takip edebilirsiniz:

1-) OAuth 2.0 sağlayıcısının yapılandırılması: Öncelikle, projenizde kullanacağınız OAuth 2.0 sağlayıcısını (Google, Facebook, Azure AD gibi) yapılandırmanız gerekmektedir. Sağlayıcının OAuth 2.0 istemcisi için gerekli istemci kimlik bilgilerini almanız ve projenizde yapılandırmanız gerekmektedir.

2-) PKCE Flow'un istemci tarafında uygulanması: İstemci (client) tarafında PKCE Flow'un gerekliliklerini uygulamanız gerekmektedir. Bunun için, rastgele bir code verifier üretmeniz ve code challenge'ı hesaplamanız gerekmektedir. Daha sonra authorization isteği yaparken code challenge'ı ve diğer gerekli parametreleri göndermeniz gerekmektedir.

3-) ASP.NET MVC projenizin yapılandırılması: ASP.NET MVC projenizde, PKCE Flow'u kullanarak kimlik doğrulama yapmak için gerekli ayarlamaları yapmanız gerekmektedir. Bu ayarlamalar, projenizin Startup.cs dosyasında yapılabilir.

4-) Kimlik doğrulama işleminin gerçekleştirilmesi: PKCE Flow'u kullanarak kimlik doğrulama işlemini gerçekleştirebilirsiniz. Bu işlem, authorization isteği, authorization code alma ve erişim token'ı alma adımlarını içerir. İsteğe bağlı olarak, refresh token'ı alma ve kullanma adımlarını da uygulayabilirsiniz.

# Sonuç

PKCE Flow, OAuth 2.0 protokolünün güvenlik zafiyetlerini gidermek için geliştirilmiş bir güvenlik mekanizmasıdır. ASP.NET MVC projelerinde PKCE Flow'u kullanarak, güvenli bir şekilde kimlik doğrulama yapabilir ve yetkilendirme işlemlerini gerçekleştirebilirsiniz.
