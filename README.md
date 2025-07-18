# PyMarkup4CS

A Python-based tool for generating markup analysis on insurance policies using AI-powered text processing.

## Overview

PyMarkup4CS is a generational program designed to analyze and extract markup information from insurance policy documents. The tool leverages the Gemma AI model to process policy text and generate structured markup data.

## Features

- AI-powered insurance policy analysis
- Automated markup generation
- Integration with Ollama for local AI model execution
- Jupyter notebook workflow for step-by-step processing

## Prerequisites

- Python 3.x
- Ollama installed on your system
- Sufficient disk space for AI models (approximately 10 GB)
- Sufficien RAM (at least 8 GB)

## Installation

1. **Install Python dependencies:**
   ```bash
   pip install -r requirements.txt
   ```

2. **Install Ollama:**
   - Visit [Ollama's official website](https://ollama.ai) for installation instructions
   - Or follow platform-specific installation guides

3. **Set up the AI model:**
   ```bash
   # Pull the Gemma model
   ollama pull hf.co/unsloth/gemma-3-4b-it-GGUF:Q8_0
   
   # Create a local model instance
   ollama create gemma --from hf.co/unsloth/gemma-3-4b-it-GGUF:Q8_0
   
   # Test the model (optional)
   ollama run gemma
   ```

## Usage

1. **Run the notebooks in sequence:**
   - Execute notebooks in numerical order (e.g., `01_preprocessing.ipynb`, `02_analysis.ipynb`, etc.)
   - Each notebook contains specific instructions and documentation

2. **Start the main application:**
   ```bash
   python main.py
   ```
