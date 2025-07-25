# PyMarkup4CS

A Python-based tool for generating markup analysis on insurance policies using AI-powered text processing.

## Overview

PyMarkup4CS is a generational program designed to markup information from insurance policy documents. The tool leverages the bge-m3 model to process policy text to the RAG system and generate structured markup data with unsloth Gemma 3 IT.

## Features

- Automated markup generation
- Integration with Ollama for local AI model execution
- Jupyter notebook workflow for step-by-step processing

## Prerequisites
- Pytorch with CUDA if you want finetuning
- Python 3.10+
- Ollama installed on your system
- Sufficient disk space for AI models (approximately 10 GB)
- Sufficien RAM (at least 8 GB)

## Installation

1. **Install Python dependencies:**
   ```bash
   pip install -r requirements.txt
   ```
2. **PyTorch CUDA (optional)**
   ````bash
   pip install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu128
   ````
3. **Install Ollama:**
   - Visit [Ollama's official website](https://ollama.ai) for installation instructions
   - Or follow platform-specific installation guides

4. **Set up the AI model:**
   ```bash
   # Pull the Gemma model
   ollama pull hf.co/unsloth/gemma-3-4b-it-GGUF:Q8_0
   
   # Create a local model instance
   ollama create gemma -f hf.co/unsloth/gemma-3-4b-it-GGUF:Q8_0

   # Start model
   ollama serve
   
   # Test the model (optional)
   ollama run gemma
   ```

## Usage

1. **Run the notebooks in sequence:**
   - Execute notebooks in numerical order 
   - Each notebook contains specific instructions and documentation

2. **Start the main application from the starter folder:**
   ```bash
   python main.py
   ```
