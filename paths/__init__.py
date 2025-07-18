from pathlib import Path

PROJECT_ROOT = Path(__file__).parent.parent
DATA_FOLDER = PROJECT_ROOT / "data"
PROCESSED_DATA_FOLDER = DATA_FOLDER / "processed_data"
MODELS_FOLDER = DATA_FOLDER / "DocProperties" / "incore-exporter" / "Workflow.DTO" / "Models"
ML_FOLDER = DATA_FOLDER / "ML"

__all__ = [
    'PROJECT_ROOT',
    'DATA_FOLDER',
    'PROCESSED_DATA_FOLDER',
    'MODELS_FOLDER',
    'ML_FOLDER'
]