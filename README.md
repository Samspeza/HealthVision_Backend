# 🩺 HealthVision

**HealthVision** é uma aplicação full stack que integra análise de imagens médicas com inteligência artificial. O sistema permite gerenciar pacientes, realizar upload de imagens e receber uma pré-análise automática via serviço de IA.

> Projeto desenvolvido com C# (ASP.NET Core), Blazor, SQLite e Python (FastAPI) como portfólio Full Stack + Inteligência Artificial.

---

## 🔍 Funcionalidades

- 📋 Cadastro e listagem de pacientes  
- 📸 Upload de imagens médicas (ex: exames, olhos, etc.)  
- 🧠 Análise automatizada da imagem usando IA (simulação)  
- 🗂️ Histórico de análises por paciente  
- 🧾 Armazenamento local com banco de dados SQLite  

---

## 🛠️ Tecnologias Utilizadas

### Backend (.NET Core)
- ASP.NET Core Web API  
- Entity Framework Core  
- SQLite  
- RESTful API  
- CORS e Static Files  

### IA Service (Python)
- FastAPI  
- Pillow (manipulação de imagens)  
- NumPy  
- Comunicação via HTTP com o backend  

### Frontend *(se aplicável)*
- Blazor WebAssembly *(ou outro, se mudar futuramente)*  

---

## 🚀 Como Executar Localmente

### 1. Clonar o repositório

bash
git clone https://github.com/seu-usuario/HealthVision.git
cd HealthVision


2. Backend (.NET)

cd HealthVision.API
dotnet restore
dotnet ef database update
dotnet run

Acesse a API em:
👉 https://localhost:5001 ou http://localhost:5000
3. Serviço de IA (Python)

cd HealthVision.IAService
pip install -r requirements.txt
uvicorn main:app --reload --host 0.0.0.0 --port 8000

📁 Estrutura do Projeto

HealthVision/
│
├── README.md
├── .gitignore
├── LICENSE
│
├── HealthVision.API/                        # 🔙 Backend ASP.NET Core
│   ├── Controllers/
│   │   ├── PatientsController.cs
│   │   └── ImagesController.cs
│   ├── Data/
│   │   ├── ApplicationDbContext.cs
│   │   └── Migrations/
│   ├── Models/
│   │   ├── Patient.cs
│   │   ├── MedicalImage.cs
│   │   └── AnalysisResult.cs
│   ├── Services/
│   │   ├── ImageAnalysisService.cs         # Chama o serviço FastAPI
│   ├── wwwroot/                            # Armazena imagens ou arquivos públicos
│   ├── appsettings.json
│   ├── Program.cs
│   ├── Startup.cs
│   └── HealthVision.API.csproj
│
├── HealthVision.IAService/                 # 🧠 Serviço de IA com FastAPI
│   ├── main.py
│   ├── models/
│   │   └── analysis.py                     # Simula análise da imagem
│   ├── utils/
│   │   └── image_processing.py
│   ├── static/
│   │   └── test_images/                    # Imagens de teste (opcional)
│   ├── requirements.txt
│   └── README.md (opcional)
│
├── HealthVision.Client/           # 🌐 Frontend com Blazor WebAssembly
│   ├── Pages/
│   │   ├── Index.razor
│   │   ├── PatientList.razor
│   │   └── UploadImage.razor
│   ├── Shared/
│   ├── wwwroot/
│   ├── Program.cs
│   ├── App.razor
│   └── HealthVision.Client.csproj
│
└── docs/                         # 📚 Documentação adicional
    ├── arquitetura.md
    ├── endpoints.md
    └── wireframes/

