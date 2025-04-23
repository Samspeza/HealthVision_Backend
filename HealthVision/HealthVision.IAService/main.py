from fastapi import FastAPI, File, UploadFile
from fastapi.middleware.cors import CORSMiddleware
from PIL import Image
import numpy as np

app = FastAPI()

# Libera CORS para a API em C#
app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],  # em produção: use a URL da sua API
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)

@app.get("/")
async def root():
    return {"message": "Serviço de IA do HealthVision ativo."}

@app.post("/analisar-imagem")
async def analisar(file: UploadFile = File(...)):
    try:
        image = Image.open(file.file).convert("RGB").resize((224, 224))
        array = np.expand_dims(np.array(image) / 255.0, axis=0)

        # Simulação de IA: se a média dos pixels for baixa, suspeita de anomalia
        resultado = "anomalia" if np.mean(array) < 0.5 else "normal"

        return {"resultado": resultado}
    except Exception as e:
        return {"erro": str(e)}
