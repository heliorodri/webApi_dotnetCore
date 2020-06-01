# WebApi .Net Core 3.x

## Cadastro de Produtos e suas respectivas categorias
<br>

#### Como testar

<br>

# Categorias

## HttpPost

### URL  
    https://localhost:5001/v1/categories

### JSon Envio
    {
        "title": "Titulo da categoria"
    }

### JSon Retorno
    {
        "id": 1,
        "title": Titulo da categoria"
    }


## HttpGet

### URL  
    https://localhost:5001/v1/categories

### JSon Retorno - Array
    [
        {
            "id": 1,
            "title": Titulo da categoria"
        },
        {
            "id": 2,
            "title": "teste dois"
        }
    ]

<br><br>

# Produtos

## HttpPost

### URL  
    https://localhost:5001/v1/products

### JSon Envio
    {
        "title": "Produto 1",
        "description": "testando",
        "price": 10,
        "categoryId":1
    }

### JSon Retorno
    {
        "id": 1,
        "title": "Produto 1",
        "description": "testando",
        "price": 10,
        "categoryId": 1
    }

## HttpGet

### URL
    https://localhost:5001/v1/products

### JSon Retorno - Array
    [
        {
            "id": 1,
            "title": "Produto 1",
            "description": "testando",
            "price": 10,
            "categoryId": 1,
            "category": {
                "id": 1,
                "title": "categ 1"
            }
        },
        {
            "id": 2,
            "title": "Produto 2",
            "description": "testando",
            "price": 10,
            "categoryId": 1,
            "category": {
                "id": 1,
                "title": "categ 1"
            }
        },
        {
            "id": 3,
            "title": "Produto 3",
            "description": "testando",
            "price": 10,
            "categoryId": 2,
            "category": {
                "id": 2,
                "title": "categ 2"
            }
        }
    ]

## HttpGet - By Id

### URL
    https://localhost:5001/v1/products/{id:int}

### Exemplo
    Requisição: 
        https://localhost:5001/v1/products/1

    Retorno:
        {
            "id": 1,
            "title": "Produto 1",
            "description": "testando",
            "price": 10,
            "categoryId": 1,
            "category": {
                "id": 1,
                "title": "categ 1"
            }
        }

## HttpGet - By Category Id


### URL
    https://localhost:5001/v1/products/categories{id:int}

### Exemplo
    Requisição: 
        https://localhost:5001/v1/products/categories//1

    Retorno:
        [
            {
                "id": 3,
                "title": "Produto 3",
                "description": "testando",
                "price": 10,
                "categoryId": 2,
                "category": {
                    "id": 2,
                    "title": "categ 2"
                }
            }
        ]



#

### Necessário desativar a opção "SLL certificate verification" no postman

#### Link com instruções
https://stackoverflow.com/questions/47806876/could-not-get-any-response-response-when-using-postman-with-subdomain