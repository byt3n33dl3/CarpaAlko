"""
Generates a Fernet key.
"""

from cryptography.fernet import Fernet
key = Fernet.generate_key()
f = Fernet(key)
print(key.decode('utf-8'))
input('')
