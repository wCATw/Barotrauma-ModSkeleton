import os
import sys
import shutil
import urllib.request
import zipfile
from io import BytesIO

def is_building_mode():
    return "--building" in sys.argv

def has_dll_files(directory):
    for root, dirs, files in os.walk(directory):
        for file in files:
            if file.lower().endswith(".dll"):
                return True
    return False

def clear_refs_folder(refs_path):
    for item in os.listdir(refs_path):
        if item == ".gitkeep":
            continue
        item_path = os.path.join(refs_path, item)
        if os.path.isfile(item_path) or os.path.islink(item_path):
            os.unlink(item_path)
        elif os.path.isdir(item_path):
            shutil.rmtree(item_path)

def download_and_extract_zip(url, extract_to):
    with urllib.request.urlopen(url) as response:
        data = response.read()
    with zipfile.ZipFile(BytesIO(data)) as zip_ref:
        zip_ref.extractall(extract_to)


# Path to Refs folder relative to this script
script_dir = os.path.dirname(os.path.abspath(__file__))
solution_root = os.path.abspath(os.path.join(script_dir, ".."))
refs_path = os.path.join(solution_root, "Refs")

if is_building_mode():
    if has_dll_files(refs_path):
        # DLLs exist, skip updating Refs folder
        sys.exit(0)

clear_refs_folder(refs_path)

zip_url = "https://github.com/evilfactory/LuaCsForBarotrauma/releases/download/latest/luacsforbarotrauma_refs.zip"
download_and_extract_zip(zip_url, refs_path)