# → Simple API to learn Elasticsearch

###### ↳ DOCKER
Para utilizar o Elasticsearch é necessário subir um contâiner Docker com sua respectiva imagem:
1. `docker pull docker.elastic.co/elasticsearch/elasticsearch:7.11.2`
2. `docker run -p 9200:9200 -e "discovery.type=single-node" docker.elastic.co/elasticsearch/elasticsearch:7.11.2`

###### ↳ API
Para utilizar a API é necessário rodar o projeto `Basic-Elasticsearch` dentro da `Basic-Elasticsearch.sln`.
<br>

###### ↳ OpenAPI
O projeto conta com o Swagger, que pode ser utilizado para inserir e recuperar `usuarios`.
<br>

###### ↳ Documentação da collection no Postman
O projeto também conta com a documentação através do Postman. Use-a para fazer consultas e inserções de `usuarios`.
<br>
→ https://documenter.getpostman.com/view/14307148/Uz5Kka32
